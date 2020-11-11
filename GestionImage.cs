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

        public GestionImage() //constructeur de la classe
        {
            this.compteur = 0;
        }

        public void supprimeVieilleImage() //permet de supprimer les images tampon et éviter de prendre trop de place en mémoire
        {
            if (compteur > 3)
            {
                File.Delete(accesVersTampon + "imageModifiee" + (compteur - 3) + ".png");
            }
        }

        public void afficheImage(PictureBox pictureBox, String chemin, String nomImage) //fonction qui permet d'afficher l'image qui vient d'être modifiée
        {
            FileStream photoStream = File.OpenRead(chemin + nomImage);
            pictureBox.Image = Image.FromStream(photoStream);
            photoStream.Close();

        }

        public void afficheImage(PictureBox pictureBox) //fonction qui permet d'afficher l'image qui vient d'être modifiée
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

        public void ResetImage(PictureBox pictureBox)
        {
            compteur = 0;
            afficheImage(pictureBox, accesVersBD, "imageDepart");

            string[] fileList = Directory.GetFiles(accesVersTampon);
            foreach (string f in fileList)
            {
                File.Delete(f);
            }
        }

        public void modifierImage(PictureBox pictureBox, String transformation, String imageDepart)
        {
            Images img = new Images(accesVersBD + imageDepart + ".png");
            img.effectuerTransformation(transformation);
            creeImage(img);
            afficheImage(pictureBox, accesVersBD, imageDepart);
        }

        public void modifierImage(PictureBox pictureBox, String transformation)
        {
            Images img = new Images(accesVersTampon + "imageModifiee" + compteur + ".png");
            img.effectuerTransformation(transformation);
            creeImage(img);
            afficheImage(pictureBox);
        }


    }
}
