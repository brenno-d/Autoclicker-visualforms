using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AutoClick
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.KeyPreview = true;
            this.TopMost = true;
            mouseButtonOption.Items.AddRange(new string[] { "Left", "Right" });
            mouseButtonOption.SelectedIndex = 0;
            msInterval.Minimum = 0;
            secondInterval.Minimum = 0;
            minuteInterval.Minimum = 0;
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

        }

        private void stopHotkey_Click(object sender, EventArgs e)
        {

        }



        private void repeatTimes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void startClicking()
        {
            int min = (int)minuteInterval.Value * 60_000;
            int sec = (int)secondInterval.Value * 1_000;
            int ms = (int)msInterval.Value;
            var mouseButton = mouseButtonOption.SelectedItem.ToString() == "Left" ? MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP : MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP;

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
                        mouse_event(mouseButton, X, Y, 0, 0);
                        mouse_event(mouseButton, X, Y, 0, 0);
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
            string pressedKey = e.KeyData.ToString();
            if (pressedKey == startkey)
            {
                startBtn.PerformClick();
            }
            else if (pressedKey == stopkey)
            {
                isClicking = false;
            }
        }

        private void repeatUntilStopped_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
