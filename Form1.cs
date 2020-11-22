using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoundAnimationMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Son.ScanSoundCards(comboBox1);
            // 
            // ecranAccueil
            // 
            PictureBox ecranAccueil = new PictureBox
            {
                Name = "ecranAccueil",
                Size = new Size(ClientSize.Width, ClientSize.Height),
                Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - ClientSize.Width, Screen.PrimaryScreen.Bounds.Height / 2 - ClientSize.Height),
                BackgroundImage = Image.FromFile("Ressources/fond.png"),
                SizeMode = PictureBoxSizeMode.AutoSize,

            };
            this.Controls.Add(ecranAccueil);
            ecranAccueil.BringToFront();
            // 
            // fenetrePrincipale
            // 
            PictureBox fenetrePrincipale = new PictureBox
            {
                Name = "fenetrePrincipale",
                Size = new Size(100, 50),
                Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2),
                //Image = Image.FromFile("claude.jpg"),

            };
            this.Controls.Add(fenetrePrincipale);
            // 
            // fenetrePrincipale
            //
            PictureBox fenetreGif = new PictureBox
            {
                Name = "fenetreGif",
                Size = new Size(100, 50),
                Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2),
                //Image = Image.FromFile("claude.jpg"),

            };
            this.Controls.Add(fenetreGif);
            // 
            // fenetreTertiaire
            //
            PictureBox fenetreTertiaire = new PictureBox
            {
                Name = "fenetreTertiaire",
                Size = new Size(100, 50),
                Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2),
                //Image = Image.FromFile("claude.jpg"),

            };
            this.Controls.Add(fenetreTertiaire);
            // 
            // button1
            // 
            Button boutonLancer = new Button
            {
                Location = new Point(159, 205),
                Name = "button1",
                Size = new Size(122, 43),
                UseVisualStyleBackColor = true,
                Image = Image.FromFile("Ressources/boutonLancer.png"),
                FlatStyle = FlatStyle.Popup,
            };
            this.Controls.Add(boutonLancer);

            //this.ClientSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //fenetrePrincipale.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }



        private void timer_Son_Tick(object sender, EventArgs e)
        {
            Son.UpdatePuissance();
        }


        private void timer_Image_Tick(object sender, EventArgs e)
        {
            //GestionImage lancement = new GestionImage(pictureBox);
            //Controleur.GererImage(lancement);
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            //Son.AudioMonitorInitialize(comboBox1.SelectedIndex);
            Thread.Sleep(50);
            timer_Image.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Son.wvin != null)
            {
                Son.wvin.StopRecording();
                Son.wvin = null;
            }
            timer_Image.Stop();
        }*/

    }
}
