using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acvarium
{
    public partial class Form1 : Form
    { 
        Timer timer = new Timer();
        bool left_muve;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();

            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Location.X <= Width - 100 && !left_muve)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                if (pictureBox1.Location.X >= Width - 110)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    left_muve = true;
                }
            }
            //else if (pictureBox1.Location.X == Width - 100 || pictureBox1.Location.X == 0)
            //{
            //    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            //    left_muve = true;
            //}
            else if (pictureBox1.Location.X >= 0 && left_muve)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                if (pictureBox1.Location.X <= 10)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    left_muve = false;
                }
            }
            
        }

        void fishMove ()
        {
            timer.Interval = 500;        }
    }
}
