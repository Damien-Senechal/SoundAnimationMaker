using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoundAnimationMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Son.ScanSoundCards(comboBox1);
        }



        private void timer_Son_Tick(object sender, EventArgs e)
        {
            Son.UpdatePuissance();
        }


        private void timer_Image_Tick(object sender, EventArgs e)
        {
           Controleur.GererImage(textBox1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, 
                label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Son.AudioMonitorInitialize(comboBox1.SelectedIndex);
            Thread.Sleep(50);
            timer_Image.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Son.wvin != null)
            {
                Son.wvin.StopRecording();
                Son.wvin = null;
            }
            timer_Image.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controleur.compteur1 = 0;
            Controleur.compteur2 = 0;
            Controleur.compteur3 = 0;
            Controleur.compteur4 = 0;
            Controleur.compteur5 = 0;
            Controleur.compteur6 = 0;
            Controleur.compteur7 = 0;
            Controleur.compteur8 = 0;
            Controleur.compteur9 = 0;
            Controleur.compteur10 = 0;
            Controleur.compteur11 = 0;

            Controleur.moyenBass0_20 = 0;
            Controleur.moyenBass20_40 = 0;
            Controleur.moyenBass40_60 = 0;
            Controleur.moyenBass60_80 = 0;
            Controleur.moyenBass80_100 = 0;
            Controleur.moyenBass100_120 = 0;
            Controleur.moyenBass120_140 = 0;
            Controleur.moyenBass140_160 = 0;
            Controleur.moyenBass160_180 = 0;
            Controleur.moyenBass180_200 = 0;
            Controleur.moyenBass200_220 = 0;
        }
    }
}
