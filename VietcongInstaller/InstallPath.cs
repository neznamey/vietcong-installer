using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietcongInstaller
{
    public partial class InstallPath : Form
    {
        public static string installationPath = null;

        public InstallPath()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            installationPath = installPathText.Text.Trim();
            Hide();
        }
    }
}
