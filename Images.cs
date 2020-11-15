using System;
using ImageMagick;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

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

        public void RedimensionnerImage()
        {
            var image = new MagickImage("images/stormCloud.jpg");
            var size = new MagickGeometry(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            size.IgnoreAspectRatio = true;

            image.Resize(size);
        }

        public void RedimensionnerImage(int largeur, int hauteur)
        {
            var image = new MagickImage("images/stormCloud.jpg");
            var size = new MagickGeometry(largeur, hauteur);
            size.IgnoreAspectRatio = true;

            image.Resize(size);
        }

        public MagickImage getImage()
        {
            return this.image;
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

                default:
                    break;
            }
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

        public void transitionEntreImage(MagickImage image2)
        {
            MagickImageCollection collection = new MagickImageCollection();
            collection.Add(image);
            collection.Add(image2);
            collection.Morph(20);
        }

        public void transitionEntreImage(MagickImage image2, int nbimage)
        {
            MagickImageCollection collection = new MagickImageCollection();
            collection.Add(image);
            collection.Add(image2);
            collection.Morph(nbimage);
        }

        public void changerCouleur(MagickColor couleurDepart, MagickColor couleurArrivee)
        {
            this.image.Opaque(couleurDepart, couleurArrivee);
        }

        public void faireArc(int pourcentageArc)
        {
            this.image.Distort(DistortMethod.Arc, pourcentageArc);
        }

        public void tourneImage(int pourcentage)
        {
            this.image.Distort(DistortMethod.ScaleRotateTranslate, pourcentage);
        }

        public void repasseContour(int niveauDeRepassage)
        {
            this.image.Edge(niveauDeRepassage);
        }

        public void recupererPartieImage(int witdh, int height)
        {
            image.Extent(witdh, height);
        }



    }
}
