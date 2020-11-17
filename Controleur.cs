using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    static class Controleur
    {
        public static void GererImage(GestionImage gestiImage)
        {
            switch (Son.getPuissance(20))
            {
                case 20:
                    gestiImage.modifierImage("flip");
                    break;
                default:
                    gestiImage.afficheImage();
                    break;

            }
        }
    }
}
