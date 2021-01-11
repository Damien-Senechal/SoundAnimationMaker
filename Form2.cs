using NAudio.CoreAudioApi;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SoundAnimationMaker
{
    public partial class Form2 : Form
    {
        private Image closePushed = Image.FromFile("Ressources/closePushed.png");
        private Image close = Image.FromFile("Ressources/close.png");
        private Form1 frmParent;
        public static PictureBox pictureGif = new PictureBox();
        private static PictureBox fondForm2 = new PictureBox();
        public Form2(Form1 frm)
        {
            InitializeComponent();
            frmParent = frm;
            Image imageDeFondForm2 = frm.pictureBox1.Image;
            timer_Son.Start();
            timer_Basse.Start();
            fondForm2.Image = imageDeFondForm2;
            fondForm2.SizeMode = PictureBoxSizeMode.StretchImage;
            fondForm2.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            buttonClose.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 135, Screen.PrimaryScreen.Bounds.Height - 35);
            fondForm2.BringToFront();
            this.Controls.Add(fondForm2);
            this.Controls.Add(pictureGif);

            Form2.pictureGif.BackColor = Color.Transparent;
            Form2.pictureGif.Location = new Point(0, 0);
            Form2.pictureGif.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Form2.pictureGif.BringToFront();

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
            Thread.Sleep(800);
            string[] fileList = Directory.GetFiles(GestionImage.accesVersTampon);
            foreach (string f in fileList)
            {
                if (f != GestionImage.accesVersTampon + "imageModifiee" + (GestionImage.compteur) + ".png")
                    File.Delete(f);
            }
            File.Move(GestionImage.accesVersTampon + "imageModifiee" + (GestionImage.compteur) + ".png", GestionImage.accesVersTampon + "imageModifiee0.png");

            GestionImage.compteur = 0;
            timer_Basse.Stop();
            timer_Son.Stop();
            Form1 form1 = new Form1();
            form1.pictureBox1.Image = fondForm2.Image;
            form1.Show();
            this.Hide();
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
            Son.checkBasse(fondForm2, gestionGlobale);
        }

        GestionImage gestionGlobale = new GestionImage(fondForm2);
        private void timer_Son_Tick(object sender, EventArgs e)
        {
            Son.UpdatePuissance();
            Controleur.GererImage(gestionGlobale);
        }

        public static int i = 0;
        private void timer_affichage_Tick(object sender, EventArgs e)
        {
            string[] filesTot = Directory.GetFiles(@"../../Image/banqueImage/", "*.png");
            if (filesTot.Length > 5)
            {
                Console.WriteLine("timerTransition, i =" + i);
                if (i < 3)
                {
                    if (File.Exists(GestionImage.accesVersTampon + "imageModifiee" + (GestionImage.compteur + 1) + "-" + i + ".png"))
                    {
                        gestionGlobale.afficheImage(GestionImage.accesVersTampon + "imageModifiee" + (GestionImage.compteur + 1) + "-" + i + ".png");
                        Thread.Sleep(100);
                        File.Delete(GestionImage.accesVersTampon + "imageModifiee" + (GestionImage.compteur + 1) + "-" + i + ".png");
                        i++;
                    }
                    else
                    {
                        string[] files = Directory.GetFiles(@"../../Image/imageTampon/", "*.png");
                        File.Move(files[0], GestionImage.accesVersTampon + "imageModifiee0.png");
                        GestionImage.compteur = 0;
                        i = 0;
                        Controleur.transiImageenCour = false;
                        Controleur.enCour = false;
                        timer_affichage.Stop();
                    }
                }
                else
                {
                    gestionGlobale.afficheImage(GestionImage.accesVersTampon + "imageModifiee" + (GestionImage.compteur + 1) + "-" + i + ".png");
                    File.Move(GestionImage.accesVersTampon + "imageModifiee" + (GestionImage.compteur + 1) + "-" + i + ".png", GestionImage.accesVersTampon + "imageModifiee" + (GestionImage.compteur + 1) + ".png");
                    GestionImage.compteur++;
                    i = 0;
                    Controleur.transiImageenCour = false;
                    Controleur.enCour = false;
                    timer_affichage.Stop();
                }
            }
        }

        private void timer_gif_Tick(object sender, EventArgs e)
        {
            
            FileStream photoStream = File.OpenRead("../../Animation/explosion.gif");
            Form2.pictureGif.Image = Image.FromStream(photoStream);
            timer_gif_explosion.Stop();

        }
    }
}
