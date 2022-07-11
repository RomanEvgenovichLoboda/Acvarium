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
        My_PictureBox pictureBox1;
        Timer timer = new Timer();
        bool left_muve;
        bool up_muve;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.BackgroundImage = global::Acvarium.Properties.Resources.acvarium;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();

            pictureBox1 = new My_PictureBox();
            Controls.Add(pictureBox1);

            //pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X <= Width - 90 && !left_muve)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                if (pictureBox1.Location.X >= Width - 100)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    left_muve = true;
                    if (pictureBox1.Location.Y <= Height - 90 && !up_muve)
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
                        if (pictureBox1.Location.Y >= Height - 100) { up_muve = true; }
                    }
                    else if (pictureBox1.Location.Y >= 0 && up_muve)
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
                        if (pictureBox1.Location.Y <= 10) { up_muve = false; }
                    }
                }
            }
            else if (pictureBox1.Location.X >= 0 && left_muve)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                if (pictureBox1.Location.X <= 10)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    left_muve = false;
                    if (pictureBox1.Location.Y <= Height - 90 && !up_muve)
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
                        if (pictureBox1.Location.Y >= Height - 100) { up_muve = true; }
                    }
                    else if (pictureBox1.Location.Y >= 0 && up_muve)
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
                        if (pictureBox1.Location.Y <= 10) { up_muve = false; }
                    }
                }
            }
        }
    }
}
