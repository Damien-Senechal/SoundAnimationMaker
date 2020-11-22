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

        
        public static int compteur1 = 0;

        public static double moyenBass10_40 = 0;

        public static double puissanceMax = 0;
        public static double moyennePuissance = 0;
        public static ArrayList listPuiss = new ArrayList();

        public static void GererImage(TextBox textBox, Label label1, Label label24, Label label2, Label label3)
        {

            int puissanceLimite = (int)moyennePuissance;

            //1
            for (int i = 1; i <= 101; i++)
            {
                moyenBass10_40 += Son.getPuissance(i);
            }
            moyenBass10_40 /= 200;

            listPuiss.Add(moyenBass10_40);
            foreach (double puiss in listPuiss)
            {
                moyennePuissance += puiss;
            }
            moyennePuissance /= listPuiss.Count;
            if (moyennePuissance < 10)
                moyennePuissance = 10;

            
            if (listPuiss.Count > 100)
            {
                for (int i = 0; i < listPuiss.Count; i++)
                {
                    listPuiss.RemoveAt(i);
                }
            }

            label24.Text = "Puissance Moyenne : " + moyennePuissance;
            if (moyenBass10_40 > puissanceMax)
            {
                puissanceMax = (int)moyenBass10_40;
                label1.Text = "Puissance Max : " + puissanceMax;
            }

            label2.Text = "Moyenne frequence 10 / 40 : " + (int)moyenBass10_40;

            //int diff = (int)(moyennePuissance / moyenBass10_40) * 100;

            if (moyenBass10_40 > moyennePuissance * 1.4)
            {
                label3.Text = "Nb basse :" + compteur1;
                compteur1++;
                moyenBass10_40 = 0;
            }
        }
    }
}
