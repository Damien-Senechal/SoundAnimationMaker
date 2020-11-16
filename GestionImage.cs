using System;
using ImageMagick;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SoundAnimationMaker
{
    class GestionImage
    {
        private int compteur; //compte le nombre d'opération sur image
        public String accesVersTampon = "././Image/ImageTampon/";
        public String accesVersBD = "././Image/banqueImage/";
        public PictureBox pictureBox;

        public GestionImage(PictureBox pictureBox) //constructeur de la classe
        {
            this.compteur = 0;
            this.pictureBox = pictureBox;
        }

        public void supprimeVieilleImage() //permet de supprimer les images tampon et éviter de prendre trop de place en mémoire
        {
            if (compteur > 3)
            {
                File.Delete(accesVersTampon + "imageModifiee" + (compteur - 3) + ".png");
            }
        }

        public void afficheImage(String chemin, String nomImage) //fonction qui permet d'afficher l'image qui vient d'être modifiée
        {
            FileStream photoStream = File.OpenRead(chemin + nomImage + ".png");
            pictureBox.Image = Image.FromStream(photoStream);
            photoStream.Close();

        }

        public void afficheImage() //fonction qui permet d'afficher l'image qui vient d'être modifiée
        {
            FileStream photoStream = File.OpenRead(accesVersTampon + "imageModifiee" + compteur + ".png");
            pictureBox.Image = Image.FromStream(photoStream);
            photoStream.Close();

        }

        public void creeImage(Images imageModifiee) 
        {
            imageModifiee.getImage().Write(accesVersTampon + "imageModifiee" + (compteur + 1) + ".png");
            compteur++;
            supprimeVieilleImage();
        }

        public void ResetImage()
        {
            compteur = 0;
            afficheImage(accesVersBD, "imageDepart");

            string[] fileList = Directory.GetFiles(accesVersTampon);
            foreach (string f in fileList)
            {
                File.Delete(f);
            }
        }

        public void InserePremiereImage(String imageDepart)
        {
            Images img = new Images(accesVersBD + imageDepart + ".png");
            creeImage(img);
            afficheImage(accesVersBD, imageDepart);
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

        public void transitionEntreImage(String nomImage)
        {
            Images img = new Images(accesVersTampon + "imageModifiee" + compteur + ".png");
            Images img2 = new Images(accesVersBD + nomImage + ".png");

        }

    }
}
