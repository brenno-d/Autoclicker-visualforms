using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace AutoClick
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;

        public Form1()
        {
            InitializeComponent();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
            


        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            githubLink.LinkArea = new LinkArea(0, githubLink.Text.Length);
            System.Diagnostics.Process.Start("https://github.com/brenno-d");
        }

        private void msInterval_TextChanged(object sender, EventArgs e)
        {

        }

        private void minuteInterval_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondInterval_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void repeatUntil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void repeatUntilStopped_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {

        }

        private void startHotkey_Click(object sender, EventArgs e)
        {

        }

        private void stopHotkey_Click(object sender, EventArgs e)
        {

        }

        private void mouseButtonOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
