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
        public static int compteur2 = 0;
        public static int compteur3 = 0;
        public static int compteur4 = 0;
        public static int compteur5 = 0;
        public static int compteur6 = 0;
        public static int compteur7 = 0;
        public static int compteur8 = 0;
        public static int compteur9 = 0;
        public static int compteur10 = 0;
        public static int compteur11 = 0;

        public static double moyenBass0_20 = 0;
        public static double moyenBass20_40 = 0;
        public static double moyenBass40_60 = 0;
        public static double moyenBass60_80 = 0;
        public static double moyenBass80_100 = 0;
        public static double moyenBass100_120 = 0;
        public static double moyenBass120_140 = 0;
        public static double moyenBass140_160 = 0;
        public static double moyenBass160_180 = 0;
        public static double moyenBass180_200 = 0;
        public static double moyenBass200_220 = 0;

        public static void GererImage(TextBox textBox, Label label2, Label label3, Label label4, Label label5, Label label6, Label label7, Label label8, Label label9, Label label10,
            Label label11, Label label12, Label label13, Label label14, Label label15, Label label16, Label label17, Label label18, Label label19, Label label20, Label label21 , Label label22, Label label23)
        {

            int puissanceLimite = Convert.ToInt32(textBox.Text);
            
            //1
            for (int i = 1; i <= 20; i++)
            {
                moyenBass0_20 += Son.getPuissance(i);
            }
            moyenBass0_20 = moyenBass0_20 / 20;
            label2.Text = "Moyenne basse 0 / 20 : " + (int) moyenBass0_20;
            if (moyenBass0_20 > 1200)
            {
                label13.Text = "Nb basse :" + compteur1;
                compteur1++;
                moyenBass0_20 = 0;
            }

            //2
            for (int i = 20; i <= 40; i++)
            {
                moyenBass20_40 += Son.getPuissance(i);
            }
            moyenBass20_40 = moyenBass20_40 / 20;
            label3.Text = "Moyenne basse 20 / 40 : " + (int) moyenBass20_40;
            if (moyenBass20_40 > puissanceLimite)
            {
                label14.Text = "Nb basse :" + compteur2;
                compteur2++;
                moyenBass20_40 = 0;
            }

            //3
            for (int i = 40; i <= 60; i++)
            {
                moyenBass40_60 += Son.getPuissance(i);
            }
            moyenBass40_60 = moyenBass40_60 / 20;
            label4.Text = "Moyenne basse 40 / 60 : " + (int) moyenBass40_60;
            if (moyenBass40_60 > puissanceLimite)
            {
                label15.Text = "Nb basse :" + compteur3;
                compteur3++;
                moyenBass40_60 = 0;
            }

            //4
            for (int i = 60; i <= 80; i++)
            {
                moyenBass60_80 += Son.getPuissance(i);
            }
            moyenBass60_80 = moyenBass60_80 / 20;
            label5.Text = "Moyenne basse 60 / 80 : " + (int) moyenBass60_80;
            if (moyenBass60_80 > puissanceLimite)
            {
                label16.Text = "Nb basse :" + compteur4;
                compteur4++;
                moyenBass60_80 = 0;
            }

            //5
            for (int i = 80; i <= 100; i++)
            {
                moyenBass80_100 += Son.getPuissance(i);
            }
            moyenBass80_100 = moyenBass80_100 / 20;
            label6.Text = "Moyenne basse 80 / 100 : " + (int) moyenBass80_100;
            if (moyenBass80_100 > puissanceLimite)
            {
                label17.Text = "Nb basse :" + compteur5;
                compteur5++;
                moyenBass80_100 = 0;
            }

            //6
            for (int i = 100; i <= 120; i++)
            {
                moyenBass100_120 += Son.getPuissance(i);
            }
            moyenBass100_120 = moyenBass100_120 / 20;
            label7.Text = "Moyenne basse 100 / 120 : " + (int) moyenBass100_120;
            if (moyenBass100_120 > puissanceLimite)
            {
                label18.Text = "Nb basse :" + compteur6;
                compteur6++;
                moyenBass100_120 = 0;
            }

            //7
            for (int i = 120; i <= 140; i++)
            {
                moyenBass120_140 += Son.getPuissance(i);
            }
            moyenBass120_140 = moyenBass120_140 / 20;
            label8.Text = "Moyenne basse 120 / 140 : " + (int) moyenBass120_140;
            if (moyenBass120_140 > puissanceLimite)
            {
                label19.Text = "Nb basse :" + compteur7;
                compteur7++;
                moyenBass120_140 = 0;
            }

            //8
            for (int i = 140; i <= 160; i++)
            {
                moyenBass140_160 += Son.getPuissance(i);
            }
            moyenBass140_160 = moyenBass140_160 / 20;
            label9.Text = "Moyenne basse 140 / 160 : " + (int) moyenBass140_160;
            if (moyenBass140_160 > puissanceLimite)
            {
                label20.Text = "Nb basse :" + compteur8;
                compteur8++;
                moyenBass140_160 = 0;
            }

            //9
            for (int i = 160; i <= 180; i++)
            {
                moyenBass160_180 += Son.getPuissance(i);
            }
            moyenBass160_180 = moyenBass160_180 / 20;
            label10.Text = "Moyenne basse 160 / 180 : " + (int) moyenBass160_180;
            if (moyenBass160_180 > puissanceLimite)
            {
                label21.Text = "Nb basse :" + compteur9;
                compteur9++;
                moyenBass160_180 = 0;
            }

            //10
            for (int i = 180; i <= 200; i++)
            {
                moyenBass180_200 += Son.getPuissance(i);
            }
            moyenBass180_200 = moyenBass180_200 / 20;
            label11.Text = "Moyenne basse 180 / 200 : " + (int) moyenBass180_200;
            if (moyenBass180_200 > puissanceLimite)
            {
                label22.Text = "Nb basse :" + compteur10;
                compteur10++;
                moyenBass180_200 = 0;
            }

            //11
            for (int i = 200; i <= 220; i++)
            {
                moyenBass200_220 += Son.getPuissance(i);
            }
            moyenBass200_220 = moyenBass200_220 / 20;
            label12.Text = "Moyenne basse 200 / 220 : " + (int) moyenBass200_220;
            if (moyenBass200_220 > puissanceLimite)
            {
                label23.Text = "Nb basse :" + compteur11;
                compteur11++;
                moyenBass200_220 = 0;
            }
        }
    }
}
