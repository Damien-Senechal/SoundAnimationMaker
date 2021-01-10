using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

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

        public static void afficherGif(String cheminGif)
        {
            PictureBox PictureGif = new PictureBox();
            PictureGif.BackColor = System.Drawing.Color.Transparent;
            PictureGif.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
            PictureGif.Name = "pictureGif";
            PictureGif.Size = new System.Drawing.Size(500, 500);
            FileStream photoStream = File.OpenRead(cheminGif);
            PictureGif.Image = Image.FromStream(photoStream);
            photoStream.Close();
        }

        public static bool enCour = false;
        public static bool transiImageenCour = false;


        public static void GererImage(GestionImage gestionImage)
        {
            Random randNum = new Random();
            if (enCour)
                return;
            if (transiImageenCour)
                return;
            enCour = true;

            compteur++;
            if (compteurTransformation > 5)
            {
                transiImageenCour = true;
                getImageRandom();
                gestionImage.transitionEntreImage(getImageRandom());
                compteurTransformation = 0;
                return;
            }

            double valGravcheckGrave = checkGrave();
            double valGravcheckMoy = checkMoy();
            double valGravcheckAigue = checkAigue();
            afficherGif("../../Animation/explosion.gif");

            if (valGravcheckAigue != 0 && valGravcheckMoy != 0)
            {
                afficherGif("../../Animation/explosion.gif");
            }

            Bpm = Son.getBpm();
            if (valGravcheckGrave != 0)
            {
                if(valGravcheckAigue < 10)
                {
                    flip = true;
                } else if (valGravcheckGrave > 10 && valGravcheckGrave <= 75)
                {
                    flop = true;
                }
                else if (valGravcheckGrave > 75 && valGravcheckGrave <= 150)
                {
                    edge = true;
                }
                else if (valGravcheckGrave > 150 && valGravcheckGrave <= 200) {
                    flou = true;
                }
            } else if (valGravcheckMoy != 0)
            {
                if (valGravcheckMoy > 200 && valGravcheckMoy <= 300)
                {
                    lumino = true;
                }
                else if (valGravcheckMoy > 300 && valGravcheckMoy <= 500)
                {
                    polar = true;
                }
                else if (valGravcheckMoy > 500 && valGravcheckMoy <= 700)
                {
                    arc = true;
                }
                else if (valGravcheckMoy > 700 && valGravcheckMoy <= 1000)
                {
                    contrast = true;
                }
                else if (valGravcheckMoy > 1000 && valGravcheckMoy <= 1500)
                {
                    coul = true;
                }
                else if (valGravcheckMoy > 1500 && valGravcheckMoy <= 2000)
                {
                    negate = true;
                }

            } else if (valGravcheckAigue != 0)
            {
                differe = true;
            } 


            if (flip)
            {
                compteurTransformation++;
                Console.WriteLine("flip");
                gestionImage.modifierImage("flip");
            }else if (flop)
            {
                Console.WriteLine("flop");
                compteurTransformation++;
                gestionImage.modifierImage("flop");
            }
            else if (negate)
            {
                Console.WriteLine("negate");
                compteurTransformation++;
                gestionImage.modifierImage("negate");
            }
            else if (gris)
            {
                Console.WriteLine("gris");
                compteurTransformation++;
                gestionImage.modifierImage("gris");
            }
            else if (flou)
            {
                Console.WriteLine("flou");
                compteurTransformation++;
                gestionImage.modifierImage("flou");
            }
            else if (polar)
            {
                Console.WriteLine("polar");
                compteurTransformation++;
                gestionImage.modifierImage("polar");
            }
            else if (differe)
            {
                Console.WriteLine("differe");
                compteurTransformation++;
                var image2 = new MagickImage();
                image2.Read(getImageRandom());
                gestionImage.modifierImage("differe", image2);
            }
            else if (lumino)
            {
                Console.WriteLine("lumino");
                compteurTransformation++;
                gestionImage.modifierImage("lumino", (int)(valGravcheckMoy / moyMoy) / 2);
            }
            else if (contrast)
            {
                Console.WriteLine("contrast");
                compteurTransformation++;
                gestionImage.modifierImage("contrast", (int)(valGravcheckMoy / moyMoy) );
            }
            else if (arc)
            {
                Console.WriteLine("arc");
                compteurTransformation++;
                gestionImage.modifierImage("arc", 5);
            }
            else if (rotate)
            {
                Console.WriteLine("rotate");
                compteurTransformation++;
                gestionImage.modifierImage("rotate", 2);
            }
            else if (edge)
            {
                Console.WriteLine("edge");
                compteurTransformation++;
                gestionImage.modifierImage("edge", (int)(valGravcheckMoy / moyMoy));
            }
            else if (coul)
            {
                Console.WriteLine("coul");
                compteurTransformation++;
                gestionImage.modifierImage("coul", new MagickColor((ushort)randNum.Next(255), (ushort)randNum.Next(255), (ushort)randNum.Next(255)), new MagickColor(100, 45, 59));
            }
            else if (cut)
            {
                Console.WriteLine("cut");
                compteurTransformation++;
                gestionImage.modifierImage("cut");
            }
            enCour = false;
        }
    }
}
