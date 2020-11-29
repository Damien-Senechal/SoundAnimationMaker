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

        
        public static int compteur = 0;

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

        public static double MoyennePuissance(int debut,int fin)
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
            return MoyennePuissance(1, 20000);
        }

        public static void GererImage(GestionImage outilsImage)
        {
            initBool();
            outilsImage.InsererPremiereImage("dophin");

            // if moyenne(a,b) > x --> transformation

            if (flip)
            {
                outilsImage.modifierImage("flip");
            }else if (flop)
            {
                outilsImage.modifierImage("flop");
            }
            else if (negate)
            {
                outilsImage.modifierImage("negate");
            }
            else if (gris)
            {
                outilsImage.modifierImage("gris");
            }
            else if (flou)
            {
                outilsImage.modifierImage("flou");
            }
            else if (polar)
            {
                outilsImage.modifierImage("flop");
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (differe)
            {
                outilsImage.modifierImage("differe");
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (lumino)
            {
                outilsImage.modifierImage("lumino");
            }
            else if (contrast)
            {
                outilsImage.modifierImage("contrast");
            }
            else if (arc)
            {
                outilsImage.modifierImage("arc");
            }
            else if (rotate)
            {
                outilsImage.modifierImage("rotate");
            }
            else if (edge)
            {
                outilsImage.modifierImage("edge");
            }
            else if (coul)
            {
                outilsImage.modifierImage("coul");
            }
            else if (cut)
            {
                outilsImage.modifierImage("cut");
            }
        }
    }
}
