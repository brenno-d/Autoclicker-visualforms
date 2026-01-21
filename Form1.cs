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
        // mouse event import
        [DllImport("user32.dll", SetLastError = true)]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        // constants and imports for global hotkeys
        public const int WM_HOTKEY = 0x0312;
        const uint MOD_NONE = 0x0000;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // end of imports

        bool isClicking = false;
        uint togglekey = (uint)Keys.F1;
        bool waitingForHotkey = false;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.TopMost = true;
            mouseButtonOption.Items.AddRange(new string[] { "Left", "Right" });
            mouseButtonOption.SelectedIndex = 0;
            msInterval.Minimum = 0;
            secondInterval.Minimum = 0;
            minuteInterval.Minimum = 0;
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, 1, MOD_NONE, togglekey);
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                // id 1 is hotkey to start/stop clicking
                if (id == 1)
                {
                    if (!isClicking)
                    {
                        startClicking();
                    }
                    else
                    {
                        isClicking = false;
                    }
                }
            }
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            githubLink.LinkArea = new LinkArea(0, githubLink.Text.Length);
            System.Diagnostics.Process.Start("https://github.com/brenno-d/Autoclicker-visualforms");
        }

        private void repeatUntil_CheckedChanged(object sender, EventArgs e)
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
            UnregisterHotKey(this.Handle, 1);
            startHotkey.Text = "Press any key...";
            this.KeyPreview = true;
            waitingForHotkey = true;
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
                        System.Threading.Thread.Sleep(totalInterval);
                    }
                }
                else
                {

                    while (isClicking)
                    {
                        uint X = (uint)Cursor.Position.X;
                        uint Y = (uint)Cursor.Position.Y;
                        mouse_event(mouseButton, X, Y, 0, 0);
                        System.Threading.Thread.Sleep(totalInterval);
                    }
                }
                isClicking = false;
            });
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);
            base.OnFormClosing(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (!waitingForHotkey)
                return;

            UnregisterHotKey(this.Handle, 1);
            togglekey = (uint)e.KeyCode;
            RegisterHotKey(this.Handle, 1, MOD_NONE, togglekey);
            startHotkey.Text = $"{e.KeyCode}";

            waitingForHotkey = false;
            e.SuppressKeyPress = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
