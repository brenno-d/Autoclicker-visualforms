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
using System.Drawing.Text;


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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.KeyPreview = true;
            this.TopMost = true;

        }
        public bool isClicking = false;
        public string startkey = "F1";
        public string stopkey = "F2";

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
            System.Diagnostics.Process.Start("https://github.com/brenno-d/Autoclicker-visualforms");
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
            startClicking();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            isClicking = false;
        }

        private void startHotkey_Click(object sender, EventArgs e)
        {
            //startHotkey.Text = "Press any key...";
            //string otkey = this.KeyDown.ToString();
        }

        private void stopHotkey_Click(object sender, EventArgs e)
        {

        }

        private void mouseButtonOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void repeatTimes_TextChanged(object sender, EventArgs e)
        {

        }
        private void click(int interval)
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            System.Threading.Thread.Sleep(interval);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void startClicking()
        {
            int min = int.Parse(minuteInterval.Text) * 60_000;
            int sec = int.Parse(secondInterval.Text) * 1_000;
            int ms = int.Parse(msInterval.Text);
            int totalInterval = min + sec + ms;
            isClicking = true;

            Task.Run(() =>
            {
                if (repeatUntil.Checked && isClicking)
                {
                    int repeatCount = int.Parse(repeatTimes.Text);
                    for (int i = 0; i < repeatCount && isClicking; i++)
                    {
                        uint X = (uint)Cursor.Position.X;
                        uint Y = (uint)Cursor.Position.Y;
                        mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                        System.Threading.Thread.Sleep(totalInterval);


                    }
                }
                else
                {

                    while (isClicking)
                    {
                        uint X = (uint)Cursor.Position.X;
                        uint Y = (uint)Cursor.Position.Y;
                        mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                        System.Threading.Thread.Sleep(totalInterval);
                    }
                }
            });
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                startBtn.PerformClick();
            }
            else if (e.KeyData == Keys.F2)
            {
                isClicking = false;
            }
        }
    }
}
