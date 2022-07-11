using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acvarium
{
    internal class My_PictureBox : PictureBox
    {
        Random random = new Random();
        public Form1 form { get; set; }
        bool left_muve;
        bool up_muve;
        public My_PictureBox()
        {
            BackColor = Color.Transparent;
            Location = new Point(random.Next(0, Program.acvarium.Width - 100), random.Next(0, Program.acvarium.Height -100));
            Size = new Size(100, 50);
            SizeMode = PictureBoxSizeMode.StretchImage;
            GetImage();
        }
       async public void Muve_My_PictureBox()
        {
            if (Location.X <= Program.acvarium.Width - 90 && !left_muve)
            {
                Location = new Point(Location.X + 10, Location.Y);
                if (Location.X >= Program.acvarium.Width - 100)
                {
                    Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    left_muve = true;
                    if (Location.Y <= Program.acvarium.Height - 90 && !up_muve)
                    {
                        Location = new Point(Location.X, Location.Y + 10);
                        if (Location.Y >= Program.acvarium.Height - 100) { up_muve = true; }
                    }
                    else if (Location.Y >= 0 && up_muve)
                    {
                        Location = new Point(Location.X, Location.Y - 10);
                        if (Location.Y <= 10) { up_muve = false; }
                    }
                }
            }
            else if (Location.X >= 0 && left_muve)
            {
                Location = new Point(Location.X - 10, Location.Y);
                if (Location.X <= 10)
                {
                    Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    left_muve = false;
                    if (Location.Y <= Program.acvarium.Height - 90 && !up_muve)
                    {
                        Location = new Point(Location.X, Location.Y + 10);
                        if (Location.Y >= Program.acvarium.Height - 100) { up_muve = true; }
                    }
                    else if (Location.Y >= 0 && up_muve)
                    {
                        Location = new Point(Location.X, Location.Y - 10);
                        if (Location.Y <= 10) { up_muve = false; }
                    }
                }
            }
            await Task.Delay(1);
        }
        public void GetImage()
        {
            switch (random.Next(1,6))
            {
                case 1:
                    {
                        Image = Properties.Resources.fish1;
                        break;
                    }
                case 2:
                    {
                        Image = Properties.Resources.fish2;
                        break;
                    }
                case 3:
                    {
                        Image = Properties.Resources.fish3;
                        break;
                    }
                case 4:
                    {
                        Image = Properties.Resources.fish4;
                        break;
                    }
                case 5:
                    {
                        Image = Properties.Resources.fish5;
                        break;
                    }
                case 6:
                    {
                        Image = Properties.Resources.fish6;
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
