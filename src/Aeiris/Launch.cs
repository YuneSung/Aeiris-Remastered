using Aeiris;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotHex
{
    public partial class Launch : Form
    {
        public Launch()
        {
            InitializeComponent();
        }

        async Task launchdelay()
        {
            await Task.Delay(5400);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private async void Launch_Load(object sender, EventArgs e)
        {
            if (File.Exists("log.txt"))
            {
                string settings = File.ReadAllText("log.txt");
                if (settings.Contains("ls:disabled"))
                {
                    this.Opacity = 0;
                    this.Hide();
                    var form2 = new MainForm();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else if (settings.Contains("ls:enabled"))
                {
                    this.TopMost = true;
                    await launchdelay();
                    this.Hide();
                    var form2 = new MainForm();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
            }
            else
            {
                File.WriteAllText("log.txt", "");
                this.TopMost = true;
                await launchdelay();
                this.Hide();
                var form2 = new MainForm();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void Launch_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
