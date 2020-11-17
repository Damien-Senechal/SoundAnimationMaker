using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoundAnimationMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Son.ScanSoundCards(comboBox1);
        }



        private void timer_Son_Tick(object sender, EventArgs e)
        {
            Son.UpdatePuissance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Son.AudioMonitorInitialize(comboBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Son.wvin != null)
            {
                Son.wvin.StopRecording();
                Son.wvin = null;
            }
        }
    }
}
