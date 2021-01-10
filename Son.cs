using NAudio.CoreAudioApi;
using SoundCardECG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundAnimationMaker
{
    static class Son 
    {
        public static NAudio.Wave.WaveInEvent wvin;
        public static Int16[] dataPcm;
        public static double[] dataFft;
        public static void AudioMonitorInitialize(
                int DeviceIndex, int sampleRate = 32_000,
                int bitRate = 16, int channels = 1,
                int bufferMilliseconds = 50, bool start = true
            )
        {
            if (wvin == null)
            {
                wvin = new NAudio.Wave.WaveInEvent();
                wvin.DeviceNumber = DeviceIndex;
                wvin.WaveFormat = new NAudio.Wave.WaveFormat(sampleRate, bitRate, channels);
                wvin.DataAvailable += OnDataAvailable;
                wvin.BufferMilliseconds = bufferMilliseconds;
                if (start)
                    wvin.StartRecording();
            }
        }

        
        public static void ScanSoundCards(ComboBox combox)
        {
            combox.Items.Clear();
            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                combox.Items.Add(NAudio.Wave.WaveIn.GetCapabilities(i).ProductName);
            }
            if (combox.Items.Count > 0)
                combox.SelectedIndex = 0;
            else
                MessageBox.Show("ERROR: pas de périphérique détecté");
        }
        
        public static void OnDataAvailable(object sender, NAudio.Wave.WaveInEventArgs args)
        {
            int bytesPerSample = wvin.WaveFormat.BitsPerSample / 8;
            int samplesRecorded = args.BytesRecorded / bytesPerSample;
            if (dataPcm == null)
                dataPcm = new Int16[samplesRecorded];
            for (int i = 0; i < samplesRecorded; i++)
            {
                dataPcm[i] = BitConverter.ToInt16(args.Buffer, i * bytesPerSample);
            }

        }

        public static void updateFFT()
        {
            // the PCM size to be analyzed with FFT must be a power of 2
            int fftPoints = 2;
            while (fftPoints * 2 <= dataPcm.Length)
                fftPoints *= 2;

            // apply a Hamming window function as we load the FFT array then calculate the FFT
            NAudio.Dsp.Complex[] fftFull = new NAudio.Dsp.Complex[fftPoints];
            for (int i = 0; i < fftPoints; i++)
                fftFull[i].X = (float)(dataPcm[i] * NAudio.Dsp.FastFourierTransform.HammingWindow(i, fftPoints));
            NAudio.Dsp.FastFourierTransform.FFT(true, (int)Math.Log(fftPoints, 2.0), fftFull);

            // copy the complex values into the double array that will be plotted
            if (dataFft == null)
                dataFft = new double[fftPoints / 2];
            for (int i = 0; i < fftPoints / 2; i++)
            {
                double fftLeft = Math.Abs(fftFull[i].X + fftFull[i].Y);
                double fftRight = Math.Abs(fftFull[fftPoints - i - 1].X + fftFull[fftPoints - i - 1].Y);
                dataFft[i] = fftLeft + fftRight;
            }
        }

        public static void UpdatePuissance()
        {
            if (Son.dataPcm == null)
                return;

            Son.updateFFT();
        }

        public static double getPuissance(int frequence)
        {
            if (Son.dataPcm == null || frequence > 8000)
                return 0;
            else if (frequence < 65)
            {
                frequence = 65;
            }
            return dataFft[(int) (frequence / 64) - 1];
        }






        //Partie basse
        public static void StartListening(ComboBox combox)
        {
            // stop the old listener if it's running
            if (ecg != null)
                ecg.Stop();

            // start a new listener
            ecg = new ECG(combox.SelectedIndex);
            ecg.beatThreshold = 2000;

            while (ecg.values == null)
                Thread.Sleep(10);

        }

        public static ECG ecg;
        public static bool busyRendering = false;

        public static int maxPuiss = 0;
        public static MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
        public static MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        public static int volume = Convert.ToInt32(defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);

        public static void mettreAJourThreshol()
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

        public static Stopwatch stopWatch = new Stopwatch();
        public static String BPMAncien = "";
        public static String BPMActuel = "";
        public static int i = 0;

        public static void checkBasse(PictureBox pictureBox2)
        {
            if (busyRendering)
                return;
            busyRendering = true;
            int thresholdMin = (7000* 2* volume / 100);
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
                        /*Random randNum = new Random();
                        int X = randNum.Next(8);
                        int Xdf = randNum.Next(8);
                        int Y = randNum.Next(3);*/

                        int X = 5;
                        int Xdf = 5;
                        int Y = 2;

                        pictureBox2.Location = new Point(pictureBox2.Location.X - Xdf, pictureBox2.Location.Y - Y);
                        System.Threading.Thread.Sleep(5);
                        pictureBox2.Location = new Point(pictureBox2.Location.X + X, pictureBox2.Location.Y + Y);
                        System.Threading.Thread.Sleep(5);
                        pictureBox2.Location = new Point(pictureBox2.Location.X - X, pictureBox2.Location.Y - Y);
                        System.Threading.Thread.Sleep(5);
                        pictureBox2.Location = new Point(pictureBox2.Location.X + X, pictureBox2.Location.Y + Y);
                        System.Threading.Thread.Sleep(5);
                        pictureBox2.Location = new Point(pictureBox2.Location.X - X, pictureBox2.Location.Y - Y);
                        System.Threading.Thread.Sleep(5);
                        pictureBox2.Location = new Point(pictureBox2.Location.X + X, pictureBox2.Location.Y + Y);
                        System.Threading.Thread.Sleep(5);
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


        public static double getBpm()
        {
            if (ecg.beatTimes != null && ecg.beatTimes.Count > 0)
                return ecg.beatRates[ecg.beatRates.Count - 1];
            else
                return 0;
        }

    }
}
