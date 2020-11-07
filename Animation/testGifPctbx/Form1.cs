using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testGifPctbx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            pictureBox1.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.Location = new Point(0, 0);
            button1.Location = new Point(Screen.PrimaryScreen.Bounds.Width-button1.Size.Width, Screen.PrimaryScreen.Bounds.Height-button1.Size.Height);
            var image = new MagickImage("images/stormcloud.jpg");
            var size = new MagickGeometry(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            size.IgnoreAspectRatio = true;

            image.Resize(size);
            image.Write("images/nuaj.png");
            pictureBox1.BackgroundImage = Image.FromFile("images/nuaj.png");

            
            trkbar1.Location = new Point(Screen.PrimaryScreen.Bounds.Width/2-(trkbar1.Width/2), Screen.PrimaryScreen.Bounds.Height/2 - (trkbar1.Height/2));
            trkbar1.Size = new Size(100, 150);
            trkbar1.Maximum = 500;
            trkbar1.Minimum = 1;
            trkbar1.Value = 100;
            trkbar1.ValueChanged += new EventHandler(trkbar1_Scroll);
            this.Controls.Add(trkbar1);
            trkbar1.BringToFront();
        }

        TrackBar trkbar1 = new TrackBar();

        private void trkbar1_Scroll(object sender, EventArgs e)
        {
            if (timer1.Interval > 0)
            {
                timer1.Interval = trkbar1.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string str = "images/pluieMoyenneTest/pluiegalere" + i + ".png";
            FileStream photoStream = File.OpenRead(str);
            pictureBox1.Image = Image.FromStream(photoStream);
            photoStream.Close();
            i++;
            i++;
            if (i == 97)
            {
                i = 1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
