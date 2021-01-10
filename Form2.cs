using NAudio.CoreAudioApi;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SoundAnimationMaker
{
    public partial class Form2 : Form
    {
        private Image closePushed = Image.FromFile("Ressources/closePushed.png");
        private Image close = Image.FromFile("Ressources/close.png");
        private Form1 frmParent;
        private static PictureBox fondForm2 = new PictureBox();
        public Form2(Form1 frm)
        {
            InitializeComponent();
            frmParent = frm;
            Image imageDeFondForm2 = frm.pictureBox1.Image;
            fondForm2.Image = imageDeFondForm2;
            fondForm2.SizeMode = PictureBoxSizeMode.StretchImage;
            fondForm2.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            buttonClose.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 135, Screen.PrimaryScreen.Bounds.Height - 35);
            fondForm2.BringToFront();
            this.Controls.Add(fondForm2);
            GestionImage outilsImage = new GestionImage(fondForm2);

            timer_Son.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Son.StartListening(frmParent.combox);
            Son.AudioMonitorInitialize(frmParent.combox.SelectedIndex);
            GestionImage.supprimeVieilleImage();
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.pictureBox1.Image = fondForm2.Image;
            form1.Show();            
            this.Hide();
            this.Close();
        }

        private void buttonClose_MouseHover(object sender, EventArgs e)
        {
            buttonClose.Image = closePushed;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.Image = close;
        }

        private void timer_Basse_Tick(object sender, EventArgs e)
        {
            Son.checkBasse(fondForm2);
        }

        GestionImage gestionGlobale = new GestionImage(fondForm2);
        private void timer_Son_Tick(object sender, EventArgs e)
        {
            Son.UpdatePuissance();
            Controleur.GererImage(gestionGlobale);
        }

        //partie son basse :

        

    }
}
