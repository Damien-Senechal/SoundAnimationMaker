using System;
using ImageMagick;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace SoundAnimationMaker
{
    class GestionImage
    {

        public static int compteur; //compte le nombre d'opération sur image
        public static String accesVersTampon = "../../Image/imageTampon/";
        public static String accesVersBD = "../../Image/banqueImage/";
        public static PictureBox pictureBox;

        public GestionImage(PictureBox pictureBox2) //constructeur de la classe
        {
            compteur = 0;
            pictureBox = pictureBox2;
        }

        public static PictureBox getPictureBox()
        {
            return pictureBox;
        }

        public static void supprimeVieilleImage() //permet de supprimer les images tampon et éviter de prendre trop de place en mémoire
        {
            string[] fileList = Directory.GetFiles(accesVersTampon);
            foreach (string f in fileList)
            {
                if ((f != accesVersTampon + "imageModifiee" + (compteur - 1) + ".png") && (f != accesVersTampon + "imageModifiee" + compteur + ".png"))
                File.Delete(f);
            }
        }

        public void afficheImage(String cheminComplet) //fonction qui permet d'afficher l'image qui vient d'être modifiée
        {
            try
            {
                FileStream photoStream = File.OpenRead(cheminComplet);
                Console.WriteLine("1 :" + cheminComplet);
                pictureBox.Image = Image.FromStream(photoStream);
                photoStream.Close();
            }
            catch (Exception)
            {
                string[] files = Directory.GetFiles(@"../../Image/imageTampon/", "*.png");
                File.Move(files[0], accesVersTampon + "imageModifiee0.png");
                compteur = 0;
            }
            

        }

        public void afficheImage() //fonction qui permet d'afficher l'image qui vient d'être modifiée
        {
            try
            {
                FileStream photoStream = File.OpenRead(accesVersTampon + "imageModifiee" + compteur + ".png");
                Console.WriteLine("2 :" + accesVersTampon + "imageModifiee" + compteur + ".png");
                pictureBox.Image = Image.FromStream(photoStream);
                photoStream.Close();
            }
            catch (Exception)
            {
                string[] files = Directory.GetFiles(@"../../Image/imageTampon/", "*.png");
                File.Move(files[0], accesVersTampon + "imageModifiee0.png");
                compteur = 0;
            }
        }

        public void creeImage(Images imageModifiee) 
        {
            imageModifiee.getImage().Write(accesVersTampon + "imageModifiee" + (compteur + 1) + ".png");
            compteur++;
            supprimeVieilleImage();
        }


        public void modifierImage(String transformation)
        {
            Images img = new Images(accesVersTampon + "imageModifiee" + compteur + ".png");
            img.effectuerTransformation(transformation);
            creeImage(img);
            afficheImage();
        }

        public void modifierImage(String transformation, MagickImage deuxiemeImage)
        {
            Images img = new Images(accesVersTampon + "imageModifiee" + compteur + ".png");
            img.effectuerTransformation(transformation, deuxiemeImage);
            creeImage(img);
            afficheImage();
        }

        public void modifierImage(String transformation, int pourcentage)
        {
            Images img = new Images(accesVersTampon + "imageModifiee" + compteur + ".png");
            img.effectuerTransformation(transformation, pourcentage);
            creeImage(img);
            afficheImage();
        }

        public void modifierImage(String transformation, int largeur, int hauteur)
        {
            Images img = new Images(accesVersTampon + "imageModifiee" + compteur + ".png");
            img.effectuerTransformation(transformation, largeur, hauteur);
            if (transformation == "cut")
                img.RedimensionnerImage();
            creeImage(img);
            afficheImage();
        }

        public void modifierImage(String transformation, MagickColor coul1, MagickColor coul2)
        {
            Images img = new Images(accesVersTampon + "imageModifiee" + compteur + ".png");
            img.effectuerTransformation(transformation, coul1, coul2);
            creeImage(img);
            afficheImage();
        }

        public void transitionEntreImage(String cheminImage)
        {
            Images img = new Images(accesVersTampon + "imageModifiee" + compteur + ".png");
            Images img2 = new Images(cheminImage);
            MagickImageCollection collection = img.transitionEntreImages(img2);
            collection.Write(accesVersTampon + "imageModifiee" + (compteur + 1) + ".png");
            Console.WriteLine("transitions");
            Thread.Sleep(800);

            Form2.timer_affichage.Start();
        }


    }
}
