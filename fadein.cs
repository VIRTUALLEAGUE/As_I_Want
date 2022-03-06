using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApp6
{
    public partial class fadein : Form
    {
        public fadein()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        private SoundPlayer Player = new SoundPlayer(WindowsFormsApp6.Properties.Resources.change);

        public void PlayMusic()
        {
            this.Player.Play();
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        private void fadein_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Start();
        }

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            double x = 0.05;
            if (this.Opacity <= 0.95)
            {
                this.Opacity += x;
            }
            else if (this.Opacity + x > 0.95)
            {
                timer1.Stop();
                //PlayMusic();
                Delay(2200);
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
