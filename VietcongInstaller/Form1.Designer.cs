namespace VietcongInstaller
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.currentYear = new System.Windows.Forms.Label();
            this.progressText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.fixMultiplayer = new System.Windows.Forms.CheckBox();
            this.desktopIcon = new System.Windows.Forms.CheckBox();
            this.ExitInstaller = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.InstallGame = new System.Windows.Forms.Button();
            this.verifyFiles = new System.Windows.Forms.CheckBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripContainer1.ContentPanel.BackgroundImage")));
            this.toolStripContainer1.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.currentYear);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.progressText);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStripContainer2);
            this.toolStripContainer1.ContentPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolStripContainer1.ContentPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(652, 375);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(652, 375);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(490, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "created by Floxen <3";
            // 
            // currentYear
            // 
            this.currentYear.AutoSize = true;
            this.currentYear.BackColor = System.Drawing.Color.Transparent;
            this.currentYear.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentYear.ForeColor = System.Drawing.Color.Gold;
            this.currentYear.Location = new System.Drawing.Point(359, 179);
            this.currentYear.Name = "currentYear";
            this.currentYear.Size = new System.Drawing.Size(0, 85);
            this.currentYear.TabIndex = 7;
            // 
            // progressText
            // 
            this.progressText.AutoSize = true;
            this.progressText.BackColor = System.Drawing.Color.Transparent;
            this.progressText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.progressText.ForeColor = System.Drawing.Color.White;
            this.progressText.Location = new System.Drawing.Point(3, 264);
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(225, 17);
            this.progressText.TabIndex = 4;
            this.progressText.Text = "Please, choose the installation path.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(147, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 85);
            this.label2.TabIndex = 6;
            this.label2.Text = "ONLINE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 85);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vietcong 1";
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripContainer2.ContentPanel.Controls.Add(this.verifyFiles);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.fixMultiplayer);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.desktopIcon);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.ExitInstaller);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.progressBar1);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.InstallGame);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(652, 91);
            this.toolStripContainer2.ContentPanel.Load += new System.EventHandler(this.toolStripContainer2_ContentPanel_Load);
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 284);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(652, 91);
            this.toolStripContainer2.TabIndex = 4;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // fixMultiplayer
            // 
            this.fixMultiplayer.AutoSize = true;
            this.fixMultiplayer.Checked = true;
            this.fixMultiplayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fixMultiplayer.ForeColor = System.Drawing.Color.White;
            this.fixMultiplayer.Location = new System.Drawing.Point(230, 18);
            this.fixMultiplayer.Name = "fixMultiplayer";
            this.fixMultiplayer.Size = new System.Drawing.Size(101, 17);
            this.fixMultiplayer.TabIndex = 6;
            this.fixMultiplayer.Text = "Fix Multiplayer";
            this.fixMultiplayer.UseVisualStyleBackColor = true;
            // 
            // desktopIcon
            // 
            this.desktopIcon.AutoSize = true;
            this.desktopIcon.Checked = true;
            this.desktopIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.desktopIcon.ForeColor = System.Drawing.Color.White;
            this.desktopIcon.Location = new System.Drawing.Point(337, 18);
            this.desktopIcon.Name = "desktopIcon";
            this.desktopIcon.Size = new System.Drawing.Size(135, 17);
            this.desktopIcon.TabIndex = 5;
            this.desktopIcon.Text = "Create Desktop ICON";
            this.desktopIcon.UseVisualStyleBackColor = true;
            // 
            // ExitInstaller
            // 
            this.ExitInstaller.BackColor = System.Drawing.Color.Transparent;
            this.ExitInstaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitInstaller.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitInstaller.ForeColor = System.Drawing.Color.White;
            this.ExitInstaller.Location = new System.Drawing.Point(121, 11);
            this.ExitInstaller.Name = "ExitInstaller";
            this.ExitInstaller.Size = new System.Drawing.Size(103, 31);
            this.ExitInstaller.TabIndex = 3;
            this.ExitInstaller.Text = "Exit";
            this.ExitInstaller.UseVisualStyleBackColor = false;
            this.ExitInstaller.Click += new System.EventHandler(this.ExitInstaller_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(628, 29);
            this.progressBar1.TabIndex = 1;
            // 
            // InstallGame
            // 
            this.InstallGame.BackColor = System.Drawing.Color.Transparent;
            this.InstallGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallGame.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InstallGame.ForeColor = System.Drawing.Color.White;
            this.InstallGame.Location = new System.Drawing.Point(12, 11);
            this.InstallGame.Name = "InstallGame";
            this.InstallGame.Size = new System.Drawing.Size(103, 31);
            this.InstallGame.TabIndex = 2;
            this.InstallGame.Text = "Choose path..";
            this.InstallGame.UseVisualStyleBackColor = false;
            this.InstallGame.Click += new System.EventHandler(this.InstallGame_Click);
            // 
            // verifyFiles
            // 
            this.verifyFiles.AutoSize = true;
            this.verifyFiles.Checked = true;
            this.verifyFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verifyFiles.ForeColor = System.Drawing.Color.White;
            this.verifyFiles.Location = new System.Drawing.Point(478, 18);
            this.verifyFiles.Name = "verifyFiles";
            this.verifyFiles.Size = new System.Drawing.Size(147, 17);
            this.verifyFiles.TabIndex = 7;
            this.verifyFiles.Text = "Verify downloaded files";
            this.verifyFiles.UseVisualStyleBackColor = true;
            this.verifyFiles.CheckedChanged += new System.EventHandler(this.VerifyDownloadedFilesChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 375);
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button InstallGame;
        private System.Windows.Forms.Button ExitInstaller;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.Label progressText;
        private System.Windows.Forms.CheckBox desktopIcon;
        private System.Windows.Forms.CheckBox fixMultiplayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox verifyFiles;
    }
}

