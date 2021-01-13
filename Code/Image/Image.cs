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

namespace SoundAnimationMaker
{
    class Image
    {
        private MagickImage image; //image
        private String accessPat; //chemin d'accés
        private double height; //hauteur
        private double width; //largeur

        public Image(String chemin)
        {
            var image = new MagickImage();
            image.Read(chemin);
            this.image = image;
            this.accessPat = chemin;
            this.height = image.Height;
            this.width = image.Width;

        }

        public MagickImage getImage()
        {
            return this.image;
        }

        public MagickImage flipImage()
        {
            this.image.Flip();

            return image;
        }

    }
}