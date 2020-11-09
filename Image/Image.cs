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
    public class Image
    {
        private String accessPat; //chemin d'accés
        private double height; //hauteur
        private double width; //largeur

        public Image(String chemin) {
            var image = new MagickImage();
            image.Read(chemin);
            
        }



    }
}