using System;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SoundAnimationMaker
{
    public partial class Form1 : Form
    {
        Image bgImg = Image.FromFile("Ressources/testFond.png");

        Image parametrePushed = Image.FromFile("Ressources/parametrePushed.png");
        Image parametre = Image.FromFile("Ressources/parametre.png");

        Image closePushed = Image.FromFile("Ressources/closePushed.png");
        Image close = Image.FromFile("Ressources/close.png");

        Image parcourirPushed = Image.FromFile("Ressources/parcourirPushed.png");
        Image parcourir = Image.FromFile("Ressources/parcourir.png");

        Image lancerPushed = Image.FromFile("Ressources/lancerPushed.png");
        Image lancer = Image.FromFile("Ressources/lancer.png");

        public Form1()
        {
            InitializeComponent();
            Son.ScanSoundCards(combox);
            Size = new Size(Screen.PrimaryScreen.Bounds.Width/2, Screen.PrimaryScreen.Bounds.Height/2);
            BackgroundImage = bgImg;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonParametre_MouseHover(object sender, EventArgs e)
        {
            buttonParametre.Image = parametrePushed;
        }

        private void buttonParametre_MouseLeave(object sender, EventArgs e)
        {
            buttonParametre.Image = parametre;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClose_MouseHover(object sender, EventArgs e)
        {
            buttonClose.Image = closePushed;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.Image = close;
        }

        private void buttonParcourir_MouseLeave(object sender, EventArgs e)
        {
            buttonParcourir.Image = parcourir;
        }

        private void buttonParcourir_MouseHover(object sender, EventArgs e)
        {
            buttonParcourir.Image = parcourirPushed;
        }

        private void buttonParametre_Click(object sender, EventArgs e)
        {
            var controlPanelPath = System.IO.Path.Combine(Environment.SystemDirectory, "control.exe");
            System.Diagnostics.Process.Start(controlPanelPath, "mmsys.cpl");
        }

        private void buttonParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                pictureBox1.Image = image;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLancer_MouseHover(object sender, EventArgs e)
        {
            buttonLancer.Image = lancerPushed;
        }

        private void buttonLancer_MouseLeave(object sender, EventArgs e)
        {
            buttonLancer.Image = lancer;
        }

        private void buttonLancer_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.AnimationDuration = 1000;
            popup.Size = new Size(200, 100);
            popup.TitleText =  "Attention";
            popup.ContentText = "Veillez à bien avoir activer votre musique avant de commencer l'exerience :D";
            popup.Popup();

            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
            
        }
    }
}
