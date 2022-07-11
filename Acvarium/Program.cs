using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acvarium
{
    static class Program
    {
        static public Image[] fishes = new Image[]
        {
            new Bitmap(Properties.Resources.fish1),
            new Bitmap(Properties.Resources.fish2),
            new Bitmap(Properties.Resources.fish3),
            new Bitmap(Properties.Resources.fish4),
            new Bitmap(Properties.Resources.fish5),
            new Bitmap(Properties.Resources.fish6)
        };
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
