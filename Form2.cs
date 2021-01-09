using NAudio.CoreAudioApi;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SoundAnimationMaker
{
    public partial class Form2 : Form
    {
        private Image closePushed = Image.FromFile("Ressources/closePushed.png");
        private Image close = Image.FromFile("Ressources/close.png");
        private Form1 frmParent;
        public Form2(Form1 frm)
        {
            
            InitializeComponent();
            frmParent = frm;
            Image imageDeFondForm2 = frm.pictureBox1.Image;
            PictureBox fondForm2 = new PictureBox();
            fondForm2.Image = imageDeFondForm2;
            fondForm2.SizeMode = PictureBoxSizeMode.StretchImage;
            fondForm2.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            buttonClose.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 135, Screen.PrimaryScreen.Bounds.Height - 35);
            fondForm2.BringToFront();
            this.Controls.Add(fondForm2);
            GestionImage outilsImage = new GestionImage(fondForm2);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();            
            this.Hide();
            this.Close();
        }

        private void buttonClose_MouseHover(object sender, EventArgs e)
        {
            buttonClose.Image = closePushed;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.Image = close;
        }

        private void timer_Son_Tick(object sender, EventArgs e)
        {
            Son.UpdatePuissance();
        }

        //partie son basse :
        private ECG ecg;
        bool busyRendering = false;
        int i = 1;

        private int maxPuiss = 0;
        private static MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
        private static MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        int volume = Convert.ToInt32(defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
        private void mettreAJourThreshol()
        {
            //réajuster le beathreshold
            foreach (int i in ecg.bufferValues)
            {
                if (maxPuiss < i)
                    maxPuiss = i;
            }

            if (maxPuiss > ecg.beatThreshold && (maxPuiss >= 7000 * ((2 * volume) / 100)))
                ecg.beatThreshold = (int)(maxPuiss * 0.95);
            maxPuiss = (int)(maxPuiss * 0.99);

        }

        private Stopwatch stopWatch = new Stopwatch();
        private String BPMAncien = "";
        private String BPMActuel = "";
        private void timerRenderGraph_Tick(object sender, EventArgs e)
        {
            if (busyRendering)
                return;

            busyRendering = true;
            int thresholdMin = (7000 * 2 * volume / 100);
            volume = Convert.ToInt32(defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);


            // create a new BPM trace from scratch
            bool cLance = true;
            if (cLance)
            {
                stopWatch.Start();
                cLance = false;
            }

            if (ecg.beatTimes != null && ecg.beatTimes.Count > 0)
            {
                BPMActuel = string.Format("{0:0.0} BPM", ecg.beatRates[ecg.beatRates.Count - 1]);

                if (BPMAncien != BPMActuel)
                {
                    if (ecg.beatThreshold > thresholdMin)
                    {
                        //vibrer image
                    }
                    BPMAncien = string.Format("{0:0.0} BPM", ecg.beatRates[ecg.beatRates.Count - 1]);
                    mettreAJourThreshol();
                    stopWatch.Restart();


                }

                if (stopWatch.ElapsedMilliseconds > 1500)
                {
                    maxPuiss = 0;
                    ecg.beatThreshold = thresholdMin;
                    mettreAJourThreshol();
                    stopWatch.Restart();
                }
            }

            Application.DoEvents();
            busyRendering = false;
        }


        private void timer_Image_Tick(object sender, EventArgs e)
        {

            //GestionImage lancement = new GestionImage(pictureBox);
            //Controleur.GererImage(lancement);
        }
    }
}
