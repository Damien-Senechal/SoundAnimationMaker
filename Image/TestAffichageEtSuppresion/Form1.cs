using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;
using System.IO;

namespace TestAffichageEtSuppresion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FileStream photoStream = File.OpenRead("imageDofins/dofin.jpg");
            pictureBox1.Image = Image.FromStream(photoStream);
            photoStream.Close();

            string[] picList = Directory.GetFiles("imageDofins", "*.jpg");
            foreach (string f in picList)
            {
                listeFichier.Text = f;
                if (!f.Equals("imageDofins\\dofin.jpg"))
                {
                    File.Delete(f);
                }
            }

            string[] picList2 = Directory.GetFiles("imageTest", "*");
            foreach (string f in picList2)
            {
                comboBox1.Items.Add(f);
            }

        }

        int i = 1;
        Boolean reset = true;

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void afficheImage(String str)
        {
            FileStream photoStream = File.OpenRead(str);
            pictureBox1.Image = Image.FromStream(photoStream);
            photoStream.Close();
            supprimeVielleImage();
        }

        private MagickImage selectImage()
        {
            var image = new MagickImage();
            if (ImageActuelle.Checked)
            {
                if (reset || i == 0)
                {
                    image.Read("imageDofins/dofin.jpg");
                    reset = false;
                }
                else
                {
                    image.Read("imageDofins/dofin" + (i - 1) + ".jpg");
                }
            }
            else
            {
                image.Read("imageDofins/dofin.jpg");
            }
            return image;
        }

        private void supprimeVielleImage()
        {
            if (i > 3)
            {
                File.Delete("imageDofins/dofin" + (i - 3) + ".jpg");
            }
        }

        private void ResetImage_Click(object sender, EventArgs e)
        {
            i = 1;
            reset = true;
            label1.Text = "i =" + i;

            afficheImage("imageDofins/dofin.jpg");

            string[] picList = Directory.GetFiles("imageDofins", "*.jpg");
            foreach (string f in picList)
            {
                listeFichier.Text = f;
                if (!f.Equals("imageDofins\\dofin.jpg")) 
                {
                    File.Delete(f);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChoisirCouleur1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Couleur1.BackColor = colorDialog1.Color;

            String r = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            label2.Text = r;

            int R = colorDialog1.Color.R;
            int G = colorDialog1.Color.G;
            int B = colorDialog1.Color.B;

            label4.Text = "rgb : " + R + ", " + ", " + G + ", " + B;
        }

        private void ChoisirCouleur2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            Couleur2.BackColor = colorDialog2.Color;

            String r = (colorDialog2.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            label3.Text = r;

            int R = colorDialog2.Color.R;
            int G = colorDialog2.Color.G;
            int B = colorDialog2.Color.B;

            label5.Text = "rgb : " + R + ", " + ", " + G + ", " + B;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            image.Flip();
            image.Write(str);
            afficheImage(str);

            label1.Text = "i =" + i;
            i++;

        }

        private void ModifieCouleurEnFonctionFauge_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            image.LevelColors(new MagickColor((ushort)trackBar1.Value, (ushort)trackBar2.Value, (ushort)trackBar3.Value), new MagickColor((ushort)trackBar4.Value, (ushort)trackBar5.Value, (ushort)trackBar6.Value));
            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        private void MettreEnGris_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            image.Grayscale();
            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        private void rotate_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            image.Rotate(trackBar7.Value);
            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        private void ModifieCouleurEnFonctionDuCHoix_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";
            var image = selectImage();

            image.LevelColors(new MagickColor(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B), new MagickColor(colorDialog2.Color.R, colorDialog2.Color.G, colorDialog2.Color.B));
            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        private void rotate90_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            image.Rotate(90);
            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        public void flip_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            //retourne image horizontalement
            image.Flip();
            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        public void chopH_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            //decoupe l'image entre debut et fin (existe aussi en vertical)
            image.ChopHorizontal(50, 200);
            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        public void edge_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            //dessine les contours des éléments de l'image (prends une taille de bordure)
            image.Edge(1);

            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        public void extent_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            //prend uniquement une image a partir du point (x,y) et sur la longueur et largeur donné
            image.Extent(50, 50, 20, 20);

            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        public void flop_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            //retourne image verticalement
            image.Flop();

            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        public void houghLine_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            //ça a fait un truc donc je la laisse mais je comprends pas comment ça marche
            image.HoughLine(10, 10, 1);

            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        public void negate_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            //negatif
            image.Negate();

            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        public void opaque_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            //changer les pixel d'une couleur donnée par une autre couleur donnée
            image.Opaque(MagickColor.FromRgb(237, 28, 36), MagickColor.FromRgb(0, 255, 0));

            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }


        private void Boucle_CheckedChanged(object sender, EventArgs e)
        {
            while (Boucle.Checked)
            {
                String str = "imageDofins/dofin" + i + ".jpg";

                var image = selectImage();

                image.Rotate(90);
                image.Write(str);

                if (i > 2)
                {
                    File.Delete("imageDofins/dofin" + (i - 1) + ".jpg");
                }

                label1.Text = "i =" + i;
                i++;
                

                afficheImage(str);
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            if (Convert.ToInt32(degreeRotate.Text) > 0)
            {
                image.Distort(DistortMethod.ScaleRotateTranslate, Convert.ToInt32(degreeRotate.Text));
            }
            image.Write(str);

            label1.Text = "i =" + i;
            i++;

            afficheImage(str);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > 0)
            {
                timer1.Interval = Convert.ToInt32(textBox1.Text);
            }
          
        }

        private void START_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Modulate_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            image.Modulate(new Percentage(50));
            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }

        public void RedimensionnerImage(MagickImage image, int largeur, int hauteur)
        {
            var size = new MagickGeometry(largeur, hauteur);
            size.IgnoreAspectRatio = true;

            image.Resize(size);
        }

        private void transparance_Click(object sender, EventArgs e)
        {
            String str = "imageDofins/dofin" + i + ".jpg";

            var image = selectImage();

            var image2 = new MagickImage(comboBox1.Text);
            RedimensionnerImage(image2, image.Width, image.Height);


            //image.CycleColormap(Convert.ToInt32(textBox2.Text));
            //image.Composite(image2, CompositeOperator.Luminize);
            image.Composite(image2, CompositeOperator.CopyGreen);

            image.Write(str);
            label1.Text = "i =" + i;
            i++;

            afficheImage(str);
        }
    }
}
