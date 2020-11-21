using System;
using ImageMagick;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace SoundAnimationMaker
{
    class Images
    {
        private MagickImage image; //image
        private String accessPath; //chemin d'accés
        private double height; //hauteur
        private double width; //largeur

        public Images(String chemin)
        {
            var image = new MagickImage();
            image.Read(chemin);
            this.image = image;
            this.accessPath = chemin;
            this.height = image.Height;
            this.width = image.Width;

        }

        public MagickImage getImage()
        {
            return this.image;
        }

        public void RedimensionnerImage()
        {
            var size = new MagickGeometry(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            size.IgnoreAspectRatio = true;

            image.Resize(size);
        }

        public void RedimensionnerImage(int largeur, int hauteur)
        {
            var size = new MagickGeometry(largeur, hauteur);
            size.IgnoreAspectRatio = true;

            image.Resize(size);
        }

        public void effectuerTransformation(String transformation)
        {
            switch (transformation)
            {
                case "flip":
                    this.flipImage();
                    break;
                case "flop":
                    this.flopImage();
                    break;
                case "negate":
                    this.negateImage();
                    break;
                case "gris":
                    this.mettreEnGris();
                    break;
                case "flou":
                    this.flou();
                    break;
                case "polar":
                    this.polar();
                    break;

                default:
                    break;
            }
        }

        public void effectuerTransformation(String transformation, MagickImage deuxiemeImage)
        {
            if (transformation == "defere") 
            differenceImage(deuxiemeImage);
        }

        public void effectuerTransformation(String transformation, int pourcentage)
        {
            switch (transformation)
            {
                case "lumino":
                    this.changerLuminasiteImage(pourcentage);
                    break;
                case "contrast":
                    this.changerContrasteImage(pourcentage); 
                    break;
                case "arc":
                    this.faireArc(pourcentage);
                    break;
                case "rotate":
                    this.rotateImage(pourcentage);
                    break;
                case "edge":
                    this.repasseContour(pourcentage);
                    break;

                default:
                    break;
            }
        }

        public void effectuerTransformation(String transformation, MagickColor coul1, MagickColor coul2)
        {
            if (transformation == "coul")
                changerCouleur(coul1, coul2);
        }

        public void effectuerTransformation(String transformation, int witdh, int height)
        {
            if (transformation == "cut")
                recupererPartieImage(witdh, height);
        }


        public void flipImage()
        {
            this.image.Flip();
        }

        public void flopImage()
        {
            this.image.Flop();
        }

        public void negateImage()
        {
            this.image.Negate();
        }

        public void mettreEnGris()
        {
            this.image.Grayscale();
        }

        public void flou()
        {
            this.image.Blur();
        }

        public void polar()
        {
            this.image.Distort(DistortMethod.Polar, 0);
        }

        public void differenceImage(MagickImage image2)
        {
            this.image.Composite(image2, CompositeOperator.Difference);
        }

        public void changerLuminasiteImage(int pourcentageLuminosite)
        {
            this.image.BrightnessContrast(new Percentage(pourcentageLuminosite), new Percentage(0));
        }

        public void changerContrasteImage(int pourcentageContraste)
        {
            this.image.BrightnessContrast(new Percentage(0), new Percentage(pourcentageContraste));
        }

        public void faireArc(int pourcentageArc)
        {
            this.image.Distort(DistortMethod.Arc, pourcentageArc);
        }

        public void rotateImage(int pourcentageTournage)
        {
            this.image.Distort(DistortMethod.ScaleRotateTranslate, pourcentageTournage);
        }

        public void repasseContour(int niveauDeRepassage)
        {
            this.image.Edge(niveauDeRepassage);
        }

        public void changerCouleur(MagickColor couleurDepart, MagickColor couleurArrivee)
        {
            this.image.Opaque(couleurDepart, couleurArrivee);
        }

        public void recupererPartieImage(int witdh, int height)
        {
            image.Extent(witdh, height);
        }


        public MagickImageCollection transitionEntreImage(Images image2)
        {
            MagickImageCollection collection = new MagickImageCollection();
            collection.Add(image);
            collection.Add(image2.image);
            collection.Morph(20);
            return collection;
        }

        public MagickImageCollection transitionEntreImage(Images image2, int nbimage)
        {
            MagickImageCollection collection = new MagickImageCollection();
            collection.Add(image);
            collection.Add(image2.image);
            collection.Morph(nbimage);
            return collection;
        }



    }
}
