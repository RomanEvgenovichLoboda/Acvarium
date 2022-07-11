using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acvarium
{
    public partial class FishControl : UserControl
    {   
        Random random = new Random();
        int hungry = 0;
        bool left_muve;
        bool up_muve;
        public int id;
        Form1 form;
        public FishControl(int id, Form1 form)
        {
            InitializeComponent();
            this.form = form;
            GetImage();
            Location = new Point(random.Next(0, form.Width - 100), random.Next(0, form.Height - 100));
            this.id = id;
        }

        async public void Muve_MyFish()
        {
            if (Location.X <= form.Width - 90 && !left_muve)
            {
                Location = new Point(Location.X + 7, Location.Y);
                if (Location.X >= form.Width - 100)
                {
                    pictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    left_muve = true;
                    if (Location.Y <= form.Height - 90 && !up_muve)
                    {
                        Location = new Point(Location.X, Location.Y + 10);
                        if (Location.Y >= form.Height - 100) { up_muve = true; }
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
                Location = new Point(Location.X - 7, Location.Y);
                if (Location.X <= 10)
                {
                    pictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    left_muve = false;
                    if (Location.Y <= form.Height - 90 && !up_muve)
                    {
                        Location = new Point(Location.X, Location.Y + 10);
                        if (Location.Y >= form.Height - 100) { up_muve = true; }
                    }
                    else if (Location.Y >= 0 && up_muve)
                    {
                        Location = new Point(Location.X, Location.Y - 10);
                        if (Location.Y <= 10) { up_muve = false; }
                    }
                }
            }
            if(hungry>=255)
            {
                form.fishDictionary.Remove(id);
                form.Controls.Remove(this);
            }
            if(hungry==252)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            }
            if(hungry<255)
            {
                hungry++;
                label.ForeColor = Color.FromArgb(hungry,0,0);
            }
            await Task.Delay(10);
        }
        public void GetImage()
        {
            switch (random.Next(1, 6))
            {
                case 1:
                    {
                        pictureBox.Image = Properties.Resources.fish1;
                        break;
                    }
                case 2:
                    {
                        pictureBox.Image = Properties.Resources.fish2;
                        break;
                    }
                case 3:
                    {
                        pictureBox.Image = Properties.Resources.fish3;
                        break;
                    }
                case 4:
                    {
                        pictureBox.Image = Properties.Resources.fish4;
                        break;
                    }
                case 5:
                    {
                        pictureBox.Image = Properties.Resources.fish5;
                        break;
                    }
                case 6:
                    {
                        pictureBox.Image = Properties.Resources.fish6;
                        break;
                    }
                default:
                    break;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            hungry = 0;
        }
    }
}
