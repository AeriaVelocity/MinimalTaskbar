using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinimalTaskbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
        }

        private void explorerStart_Click(object sender, EventArgs e)
        {
            Process explorer = new Process();
            explorer.StartInfo.FileName = "explorer.exe";
            explorer.StartInfo.UseShellExecute = false;
            explorer.Start();
        }

        private void explorerKill_Click(object sender, EventArgs e)
        {
            Process exKill = new Process();
            exKill.StartInfo.FileName = "taskkill.exe";
            exKill.StartInfo.Arguments = "/f /im explorer.exe";
            exKill.StartInfo.UseShellExecute = false;
            exKill.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string Message, Title;
            Message = "Do you really want to quit Minimal Taskbar?\nIf you do not have Explorer open, you will have to start it manually.\nIf not blocked, you can use Task Manager to run explorer.exe, otherwise expect to restart your computer.";
            Title = "Really quit?";
            var closeMsg = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (closeMsg == DialogResult.No);
        }

        private void taskmgrStart_Click(object sender, EventArgs e)
        {
            Process taskmgr = new Process();
            taskmgr.StartInfo.FileName = "taskmgr.exe";
            taskmgr.StartInfo.UseShellExecute = false;
            taskmgr.Start();
        }

        private void shutDown_Click(object sender, EventArgs e)
        {
            string Message, Title;
            Message = "Are you sure you want to shut down?\nThis will end your Windows session.";
            Title = "Really shut down?";
            var ShutdownConfirm = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ShutdownConfirm == DialogResult.Yes)
            {
                Process.Start("shutdown.exe", @"-s -t 0");
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            string Message, Title;
            Message = "Are you sure you want to restart your computer?";
            Title = "Really restart?";
            var RestartConfirm = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (RestartConfirm == DialogResult.Yes)
            {
                Process.Start("shutdown.exe", @"-r -t 0");
            }
        }
    }
}
