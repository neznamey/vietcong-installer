using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

namespace VietcongInstaller
{
    public partial class Form1 : Form
    {
        private string path = "C:\\Program Files\\WhareSquare\\Vietcong 1";

        public Form1()
        {
            InitializeComponent();
            currentYear.Text = DateTime.Now.Year.ToString();
        }

        private void ExitInstaller_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void InstallGame_Click(object sender, EventArgs e)
        {
            if (InstallPath.installationPath == null)
            {
                new InstallPath().ShowDialog();

                if (InstallPath.installationPath != null)
                {
                    progressText.Text = "Ok! Path choosen, now you can install the game.";
                    InstallGame.Text = "Install game";
                }
            }
            else
            {
                ExitInstaller.Enabled = false;
                InstallGame.Enabled = false;
                fixMultiplayer.Enabled = false;
                desktopIcon.Enabled = false;
                verifyFiles.Enabled = false;
                new Thread(RunDownloadTask).Start();
            }
        }

        public void RunDownloadTask()
        {
            progressText.Text = "Initiating installation..";

            Thread.Sleep(1500);

            progressBar1.Value = 0;

            if (desktopIcon.Checked)
            {
                CreateFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Run Vietcong.bat", "@echo off\necho.\necho    The vietcong is installing. Please, wait to finish installation.\necho.\npause>nul\nexit /b 0\n");
            }

            CreateDir(path);
            CreateDir(path + "\\saves");
            CreateDir(path + "\\cfg");
            CreateDir(path + "\\maps");

            string pth = path;

            path = Environment.CurrentDirectory;

            DownloadFile("requirements.txt");
            DownloadFile("checksums.txt");

            path = pth;

            List<string> files = new List<string>();

            if (File.Exists(Environment.CurrentDirectory + "\\requirements.txt"))
            {
                foreach (var file in File.ReadLines("requirements.txt"))
                {
                    if (!file.StartsWith("#"))
                    {
                        files.Add(file);
                    }
                }

                for (int index = 0; index < files.Count; index++)
                {
                    string currentFile = files[index];
                    DownloadFile(currentFile);
                    progressBar1.Value += 4;
                    progressText.Text = "Downloading file " + currentFile + "..";
                    Thread.Sleep(50);
                }

                if (desktopIcon.Checked)
                {
                    progressText.Text = "Completing desktop icon...";
                    CreateFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Run Vietcong.bat", "@echo off\n\"" + path + "\\vc.bat\"\n");
                    CreateFile(path + "\\vc.bat", "@echo off\ncd \"" + path + "\"\nstart \"\" \"" + path + "\\vietcong.exe\"\n");
                    Thread.Sleep(2000);
                }

                if (fixMultiplayer.Checked)
                {
                    progressText.Text = "Fixing the multiplayer..";
                    CreateFile("C:\\Windows\\System32\\drivers\\etc\\hosts", "46.28.109.117 master.gamespy.com\n");
                    Thread.Sleep(2000);
                }

                
                if (verifyFiles.Checked)
                {
                    progressBar1.Value = 90;

                    progressText.Text = "Veryfing downloaded files using SHA256, this can take a moment..";

                    Thread.Sleep(2000);

                    if (VerifyDownloadedFiles() == 23)
                    {
                        progressBar1.Value = 100;
                        progressText.Text = "Installation done! You can close this installer.";
                        ExitInstaller.Enabled = true;
                        InstallGame.Enabled = false;

                        if (File.Exists(Environment.CurrentDirectory + "\\requirements.txt"))
                        {
                            File.Delete(Environment.CurrentDirectory + "\\requirements.txt");
                        }

                        if (File.Exists(Environment.CurrentDirectory + "\\checksums.txt"))
                        {
                            File.Delete(Environment.CurrentDirectory + "\\checksums.txt");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error veryfing files, you using this at your own risk! (i should remove files and find another solution to get this game)");
                    }
                }
                else
                {
                    progressBar1.Value = 100;

                    progressText.Text = "Installation done! You can close this installer.";
                    ExitInstaller.Enabled = true;
                    InstallGame.Enabled = false;

                    if (File.Exists(Environment.CurrentDirectory + "\\requirements.txt"))
                    {
                        File.Delete(Environment.CurrentDirectory + "\\requirements.txt");
                    }

                    if (File.Exists(Environment.CurrentDirectory + "\\checksums.txt"))
                    {
                        File.Delete(Environment.CurrentDirectory + "\\checksums.txt");
                    }
                }

                MessageBox.Show("Installation completed!", "Installer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cannot find a file requirements.txt!");
                Environment.Exit(0);
            }
        }

        public class FileVerifyStruct
        {
            public string Hash;
        }

        public List<FileVerifyStruct> verifyFileList = new List<FileVerifyStruct>();

        public int VerifyDownloadedFiles()
        {
            int verify = 0;

            if (File.Exists(Environment.CurrentDirectory + "\\checksums.txt"))
            {
                foreach (var file in File.ReadLines(Environment.CurrentDirectory + "\\checksums.txt"))
                {
                    if (!file.StartsWith("#") && file.Contains("  "))
                    {
                        string[] data = file.Split(new[] { "  " }, StringSplitOptions.None);

                        verifyFileList.Add(new FileVerifyStruct { Hash = data[0].Trim() });
                    }
                }

                foreach (var files in Directory.GetFiles(path))
                {

                    string sha = SHA256CheckSum(files);
                    
                    foreach (var hash in verifyFileList)
                    {
                        if (hash.Hash == sha)
                        {
                            verify++;
                            progressText.Text = "Verifying: " + files;
                            break;
                        }
                    }
                }
            }

            return verify;
        }

        public string SHA256CheckSum(string filePath)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                using (FileStream fileStream = File.OpenRead(filePath))
                {
                    return BitConverter.ToString(sha256.ComputeHash(fileStream)).Replace("-", "");
                }
            }
        }

        public void CreateDir(string dirName)
        {
            progressText.Text = "Creating file: " + dirName;
            progressBar1.Value++;
            Directory.CreateDirectory(dirName);
            Thread.Sleep(200);
        }

        public void CreateFile(string fileName, string content)
        {
            progressText.Text = "Creating file: " + fileName;
            progressBar1.Value++;
            File.WriteAllText(fileName, content);
            Thread.Sleep(200);
        }

        public void DownloadFile(string fileName)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("https://cdn.wharesquare.eu/vietcong-raw-files/" + fileName, path + "\\" + fileName);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("   -> Downloading file:");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" " + fileName);
                Console.ForegroundColor = ConsoleColor.White;

                while (!File.Exists(path + "\\" + fileName))
                {
                    Thread.Sleep(150);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" OK!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void toolStripContainer2_ContentPanel_Load(object sender, EventArgs e)
        {
        }

        private void VerifyDownloadedFilesChanged(object sender, EventArgs e)
        {
            if (!verifyFiles.Checked)
            {
                var res = MessageBox.Show("Warning!\n\nThis is not recommended, i recommend to verify the downloaded files!\n\nWe not take any responsibility if you get any problems!\n\nDo you really want cancel verification?", "Warning ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    verifyFiles.Checked = false;
                }
                else
                {
                    verifyFiles.Checked = true;
                }
            }
        }
    }
}
