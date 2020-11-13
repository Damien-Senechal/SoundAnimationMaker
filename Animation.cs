using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundAnimationMaker
{
    static class Animation
    {
        public static void lancerAnimation(String chemin, String nomImage, PictureBox pictureBox)
        {
            int i = 1;
            int nbFichiersJPG = Directory.GetFiles(chemin, "*.png", SearchOption.AllDirectories).Length - 1;
            string str = chemin + nomImage + i + ".png";

            FileStream photoStream = File.OpenRead(str);
            pictureBox.Image = Image.FromStream(photoStream);
            photoStream.Close();

            i++;
            if (i > nbFichiersJPG)
            {
                i = 1;
            }
        }
    }
}
