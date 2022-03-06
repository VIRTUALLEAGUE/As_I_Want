using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp6
{
    public partial class lose : Form
    {
        public lose()
        {
            InitializeComponent();
            play();
        }
        private SoundPlayer laug = new SoundPlayer(WindowsFormsApp6.Properties.Resources.joker_laugh);
        private void play()
        {
            this.laug.Play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            this.Close();
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
    }
}
