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
                    this.NegateImage();
                    break;

                default:
                    break;
            }
        }

        public MagickImage flipImage()
        {
            this.image.Flip();
            return image;
        }

        public MagickImage flopImage()
        {
            this.image.Flop();
            return image;
        }

        public MagickImage NegateImage()
        {
            this.image.Grayscale();
            return image;
        }

    }
}
