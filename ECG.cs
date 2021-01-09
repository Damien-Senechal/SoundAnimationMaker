using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundCardECG
{
    public class ECG
    {
        public int SAMPLERATE = 8000;
        int BITRATE = 16;
        int CHANNELS = 1;
        int BUFFERMILLISEC = 20;
        int STORESECONDS = 5;
        int bufferIndex = 0;
        int buffersCaptured = 0;
        public int beatThreshold = 2000;
        public double signalMultiple = 1;

        public List<double> beatTimes = new List<double>();
        public List<double> beatRates = new List<double>();

        NAudio.Wave.WaveInEvent wvin;

        public double[] values;
        public double[] times;

        private static MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
        private static MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        int volume = Convert.ToInt32(defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);

        public ECG(int deviceNumber)
        {
            wvin = new NAudio.Wave.WaveInEvent();
            wvin.DeviceNumber = deviceNumber;
            wvin.WaveFormat = new NAudio.Wave.WaveFormat(SAMPLERATE, BITRATE, CHANNELS);
            wvin.BufferMilliseconds = BUFFERMILLISEC;
            wvin.DataAvailable += OnDataAvailable;
            Start();
        }

        public void Start()
        {
            wvin.StartRecording();
        }

        public void Stop()
        {
            wvin.StopRecording();
        }



        private void BeatDetected(double timeSec)
        {
            double beatRate = 0;
            if (beatTimes.Count > 0)
            {
                double beatToBeatTime = timeSec - beatTimes[beatTimes.Count - 1];
                beatRate = 1.0 / beatToBeatTime * 60;
                if (beatRate > 250)
                    return;
            }
            beatTimes.Add(timeSec);
            beatRates.Add(beatRate);

            // fix the first heartbeat which lacks a BPM
            if (beatRates.Count > 0 && beatRates[0] == 0)
                beatRates[0] = beatRate;
        }

        public int lastPointUpdated = 0;
        public double[] bufferValues;
        public double beatTimeSec;
        private void OnDataAvailable(object sender, NAudio.Wave.WaveInEventArgs args)
        {
            // convert from a 16-bit byte array to a double array
            int bytesPerValue = BITRATE / 8;
            int valuesInBuffer = args.BytesRecorded / bytesPerValue;
            bufferValues = new double[valuesInBuffer];
            for (int i = 0; i < valuesInBuffer; i++)
            {
                bufferValues[i] = BitConverter.ToInt16(args.Buffer, i * bytesPerValue) * signalMultiple;
                //Console.WriteLine("bufferValue :" + Math.Abs(bufferValues[i]));
            }
            //Console.WriteLine("bufferValue :" + Math.Abs(bufferValues[10]));
            double moyennePuiss = 0;
            foreach (var item in bufferValues)
            {
                moyennePuiss += item;
            }
            //Console.WriteLine("bufferValue :" + (moyennePuiss / bufferValues.Length));

            //Console.WriteLine("threashold :" + beatThreshold);
            // determine if a heartbeat occured

            int j = 0;

            while (j < bufferValues.Length)
            {
                if (bufferValues[j] > beatThreshold)
                {
                    int beatSampleNumber = j + buffersCaptured * valuesInBuffer;
                    beatTimeSec = (double)beatSampleNumber / SAMPLERATE;
                    BeatDetected(beatTimeSec);
                    break;
                }
                j++;
            }

            // create the values buffer if it does not exist
            if (values == null)
            {
                int idealSampleCount = STORESECONDS * SAMPLERATE;
                int bufferCount = idealSampleCount / valuesInBuffer;
                values = new double[bufferCount * valuesInBuffer];
                times = new double[bufferCount * valuesInBuffer];
                for (int i = 0; i < times.Length; i++)
                    times[i] = (double)i / SAMPLERATE;
            }

            // copy these data into the correct place of the larger buffer
            Array.Copy(bufferValues, 0, values, bufferIndex * valuesInBuffer, bufferValues.Length);
            lastPointUpdated = bufferIndex * valuesInBuffer + bufferValues.Length;

            // update counts
            buffersCaptured += 1;
            bufferIndex += 1;
            if (bufferIndex * valuesInBuffer > values.Length - 1)
                bufferIndex = 0;
        }
    }
}
