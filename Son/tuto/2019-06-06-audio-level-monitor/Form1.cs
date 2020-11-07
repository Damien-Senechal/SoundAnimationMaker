using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPeak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            double[] tabvaleur = new double[500];
            InitializeComponent();
            ScanSoundCards();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ScanSoundCards()
        {
            cbDevice.Items.Clear();
            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
                cbDevice.Items.Add(NAudio.Wave.WaveIn.GetCapabilities(i).ProductName);
            if (cbDevice.Items.Count > 0)
                cbDevice.SelectedIndex = 0;
            else
                MessageBox.Show("ERROR: no recording devices available");
        }

        

        private NAudio.Wave.WaveInEvent wvin;
        private int buffersRead = -1;
        private double peakAmplitudeSeen = 0;
        private void OnDataAvailable(object sender, NAudio.Wave.WaveInEventArgs args)
        {
            int bytesPerSample = wvin.WaveFormat.BitsPerSample / 8;
            int samplesRecorded = args.BytesRecorded / bytesPerSample;
            Int16[] lastBuffer = new Int16[samplesRecorded];
            for (int i = 0; i < samplesRecorded; i++)
                lastBuffer[i] = BitConverter.ToInt16(args.Buffer, i * bytesPerSample);
            int lastBufferAmplitude = lastBuffer.Max() - lastBuffer.Min();
            double amplitude = (double)lastBufferAmplitude / Math.Pow(2, wvin.WaveFormat.BitsPerSample);
            if (amplitude > peakAmplitudeSeen)
                peakAmplitudeSeen = amplitude;
            amplitude = amplitude / peakAmplitudeSeen * 100;
            buffersRead += 1;
            // TODO: make this sane
            label2.Invoke(new MethodInvoker(delegate
            {
                label2.Text = "valeur " + amplitude;
            }));
        }

        private void AudioMonitorInitialize(int DeviceIndex, int sampleRate = 8000, int bitRate = 16,
                int channels = 1, int bufferMilliseconds = 20, bool start = true)
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


        private void BtnStart_Click(object sender, EventArgs e)
        {
            AudioMonitorInitialize(cbDevice.SelectedIndex);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (wvin != null)
            {
                wvin.StopRecording();
                wvin = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
