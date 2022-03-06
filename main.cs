using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Net;

namespace WindowsFormsApp6
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            label2.Hide();
            label3.Hide();
            if (count >= 20)
            {
                this.Hide();
                playsound playsoundForm = new playsound();
                playsoundForm.ShowDialog();
            }
        }
        private static DateTime Delay(int MS)   //private static DateTime Delay(int MS)
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


        private void main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            
        }
        private Point mCurrentPosition = new Point(0, 0);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
                mCurrentPosition = new Point(-e.X, -e.Y);

        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (mCurrentPosition.X + e.X), this.Location.Y + (mCurrentPosition.Y + e.Y));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            this.Close();
        }
        int count = 0;
        int time = 2500;
        int total = 60;
        private void button1_Click(object sender, EventArgs e)
        {
            //string msg = "Something is Wrong!! Umm... Are u change the date at CMD?";
            /*
            if (count == 4)
            {
                if (total > 35)
                {
                    MessageBox.Show("Why r u in such a hurry? There's no rush - take ur time", "lol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    lose loseForm = new lose();
                    loseForm.ShowDialog();
                }
            }
            if (count == 6)
            {
                if (total > 20)
                {
                    MessageBox.Show("Why r u in such a hurry? There's no rush - take ur time", "lol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    lose loseForm = new lose();
                    loseForm.ShowDialog();
                }
            }
            if (count == 7)
            {
                if (total > 7)
                {
                    MessageBox.Show("Why r u in such a hurry? There's no rush - take ur time", "lol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    lose loseForm = new lose();
                    loseForm.ShowDialog();
                }
            }
            if (count == 18)
            {
                if (total > 20)
                {
                    MessageBox.Show("Changing time is not way I want it to be.", "lol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    lose loseForm = new lose();
                    loseForm.ShowDialog();
                }
            }
            */
            if (count >= 20)
            {
                this.Hide();
                button1.Text = Convert.ToString("PassCode is {ShADoW CTF 20EO}");   //fake PassCode // prevent IDA
                playsound playsoundForm = new playsound();
                playsoundForm.ShowDialog();
            }
            count++;
            button1.Hide();
            label2.Show();
            label3.Text = Convert.ToString(1.5 * count);
            label3.Show();
            label1.Text = Convert.ToString(count);
            if (count != 1)
            {
                time += 1500;
                Delay(time);
            }
            label2.Hide();
            label3.Hide();
            button1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            total--;
            label5.Text = Convert.ToString(total);
            if (total == 0)
            {
                this.Hide();
                lose loseForm = new lose();
                loseForm.ShowDialog();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
