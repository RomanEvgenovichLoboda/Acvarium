using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acvarium
{
    internal class My_PictureBox : PictureBox
    {
        Random random = new Random();
        public My_PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent;
            Image = Program.fishes[random.Next(0,5)];
            Location = new System.Drawing.Point(random.Next(0, 100), random.Next(0, 100));
            Size = new System.Drawing.Size(100, 50);
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }
    }
}
