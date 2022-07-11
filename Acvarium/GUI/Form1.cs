using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Acvarium
{
    public partial class Form1 : Form
    {
        int ids = 0;
        public Dictionary<int, FishControl> fishDictionary;

        Timer timer = new Timer();
       
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.BackgroundImage = Properties.Resources.acvarium;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
            fishDictionary = new Dictionary<int, FishControl>();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(fishDictionary.Count > 0)
            {
                try
                {
                    foreach (var item in fishDictionary.Values)
                    {
                        item.Muve_MyFish();
                    }
                }
                catch (Exception)
                {
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FishControl fishControl = new FishControl(ids,this);
            fishDictionary.Add(ids, fishControl);
            Controls.Add(fishControl);
            ids++;
        }
    }
}
