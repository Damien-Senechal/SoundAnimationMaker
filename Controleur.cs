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
        public static double moyTamponGrave = 0;
        public static int compteurMoyGrave = 1;
        public static double moyGrave = 0;
        public static double moyTamponMoy = 0;
        public static int compteurMoyMoy = 1;
        public static double moyMoy = 0;
        public static double moyTamponAigue = 0;
        public static int compteurMoyAigue = 1;
        public static double moyAigue = 0;

        public static int compteur = 0;
        public static int compteurTransformation = 0;

        public static double Bpm = 0;
        public static bool flip, flop, negate, gris, flou, polar, differe, lumino, contrast, arc, rotate, edge, coul, cut;

        public static void initBool()
        {
            flip = false;
            flop = false;
            negate = false;
            gris = false;
            flou = false;
            polar = false;
            differe = false;
            lumino = false;
            contrast = false;
            arc = false;
            rotate = false;
            edge = false;
            coul = false;
            cut = false;
        }

        public static double moyennePuissance(int debut,int fin)
        {
            double somme = 0;
            int effectif = fin - debut;

            for(int i = debut; i <= fin; i++)
            {
                somme += Son.getPuissance(i);
            }

            return somme / effectif;
        }

        public static double MoyenneTotale()
        {
            return moyennePuissance(1, 20000);
        }

        //partie Grave
        public static double checkGrave() 
        {
            moyGrave = moyennePuissance(0, 200);
            moyTamponGrave += moyGrave;
            compteurMoyGrave++;
            moyGrave = (moyTamponGrave) / compteurMoyGrave;

            for (int i = 0; i < 200; i++)
            {
                if (Son.getPuissance(i) > 2 * moyMoy && Son.getPuissance(i) > 100) {
                    initBool();
                    return Son.getPuissance(i);
                }
            }
            return 0;
        }

        //partie moyenne
        public static double checkMoy()
        {
            moyMoy = moyennePuissance(200, 2000);
            moyTamponMoy += moyMoy;
            compteurMoyGrave++;
            moyMoy = (moyTamponMoy) / compteurMoyGrave;

            for (int i = 200; i < 2000; i++)
            {
                if (Son.getPuissance(i) > 2 * moyMoy && Son.getPuissance(i) > 100)
                {
                    initBool();
                    return Son.getPuissance(i);
                }
            }
            return 0;
        }


        //partie aigue
        public static double checkAigue()
        {
            moyAigue = moyennePuissance(2000, 8000);
            moyTamponAigue += moyAigue;
            compteurMoyAigue++;
            moyAigue = (moyTamponAigue) / compteurMoyAigue;

            for (int i = 0; i < 200; i++)
            {
                if (Son.getPuissance(i) > 2 * moyAigue && Son.getPuissance(i) > 100)
                {
                    initBool();
                    return Son.getPuissance(i);
                }
            }
            return 0;
        }

        public static String getImageRandom()
        {
            string[] files = Directory.GetFiles(@"../../Image/banqueImage/", "*.png");
            Random rd = new Random();
            int X = rd.Next(files.Length);
            return files[X];
        }

        public static bool enCour = false;
        public static bool transiImageenCour = false;
        public static void GererImage(GestionImage gestionImage)
        {
            Console.WriteLine(transiImageenCour);
            if (enCour)
                return;
            enCour = true;
            if (transiImageenCour)
                return;

            double valGravcheckGrave = checkGrave();
            double valGravcheckMoy = checkMoy();
            double valGravcheckAigue = checkAigue();
            getImageRandom();
            compteur++;
            if (compteur > 10) {
                compteur = 0;
                initBool();
            }
            if (compteurTransformation > 5)
            {
                transiImageenCour = true;
                gestionImage.transitionEntreImage(getImageRandom());
                compteurTransformation = 0;
            }
            Bpm = Son.getBpm();
            if (valGravcheckGrave != 0)
            {
                if(valGravcheckAigue < 10)
                {
                    flop = true;
                    Console.WriteLine("flop");
                } else if (valGravcheckGrave > 10 && valGravcheckGrave <= 100)
                {
                    rotate = true;
                    Console.WriteLine("rotate");
                } else if (valGravcheckGrave > 100 && valGravcheckGrave <= 200) {
                    flip = true;
                    Console.WriteLine("flip");
                }
            } else if (valGravcheckMoy != 0)
            {
                if (valGravcheckMoy > 200 && valGravcheckMoy <= 300)
                {
                    lumino = true;
                    Console.WriteLine("lumino");
                }
                else if (valGravcheckMoy > 300 && valGravcheckMoy <= 500)
                {
                    rotate = true;
                    Console.WriteLine("rotate");
                }
                else if (valGravcheckMoy > 500 && valGravcheckMoy <= 700)
                {
                    polar = true;
                    Console.WriteLine("polar");
                }
                else if (valGravcheckMoy > 700 && valGravcheckMoy <= 1000)
                {
                    arc = true;
                    Console.WriteLine("arc");
                }
                else if (valGravcheckMoy > 1000 && valGravcheckMoy <= 1500)
                {
                    flou = true;
                    Console.WriteLine("flou");
                }
                else if (valGravcheckMoy > 1500 && valGravcheckMoy <= 2000)
                {
                    contrast = true;
                    Console.WriteLine("contrast");
                }

            } else if (valGravcheckAigue != 0)
            {

            } else
            {
                //initBool();
            }


            if (flip)
            {
                compteurTransformation++;
                gestionImage.modifierImage("flip");
            }else if (flop)
            {
                compteurTransformation++;
                gestionImage.modifierImage("flop");
            }
            else if (negate)
            {
                compteurTransformation++;
                gestionImage.modifierImage("negate");
            }
            else if (gris)
            {
                compteurTransformation++;
                gestionImage.modifierImage("gris");
            }
            else if (flou)
            {
                compteurTransformation++;
                gestionImage.modifierImage("flou");
            }
            else if (polar)
            {
                compteurTransformation++;
                gestionImage.modifierImage("polar");
            }
            else if (differe)
            {
                compteurTransformation++;
                gestionImage.modifierImage("differe");
            }
            else if (lumino)
            {
                compteurTransformation++;
                gestionImage.modifierImage("lumino", (int)(valGravcheckMoy / moyMoy));
            }
            else if (contrast)
            {
                compteurTransformation++;
                gestionImage.modifierImage("contrast", (int)(valGravcheckMoy / moyMoy) / 2);
            }
            else if (arc)
            {
                compteurTransformation++;
                gestionImage.modifierImage("arc", 1);
            }
            else if (rotate)
            {
                compteurTransformation++;
                gestionImage.modifierImage("rotate", (int)(valGravcheckGrave / moyGrave));
            }
            else if (edge)
            {
                compteurTransformation++;
                gestionImage.modifierImage("edge", (int)(valGravcheckMoy / moyMoy));
            }
            else if (coul)
            {
                compteurTransformation++;
                gestionImage.modifierImage("coul", new MagickColor(200,200,200), new MagickColor(100,45,59));
            }
            else if (cut)
            {
                compteurTransformation++;
                gestionImage.modifierImage("cut");
            }
            enCour = false;
        }
    }
}
