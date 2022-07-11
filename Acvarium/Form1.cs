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

        List<My_PictureBox> fishList;
        

        Timer timer = new Timer();
       
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.BackgroundImage = Properties.Resources.acvarium;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
;
            fishList = new List<My_PictureBox>();

            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(fishList.Count > 0)
            {
                foreach (var item in fishList)
                {
                    item.Muve_My_PictureBox();
                }
            }

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            My_PictureBox fishBox = new My_PictureBox();
            fishBox.form = this;
            fishList.Add(fishBox);
            Controls.Add(fishBox);
        }
    }
}
