using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuDienOnline
{
     static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread main = new Thread(new ThreadStart(start));
            main.Start();
            Thread.Sleep(4000);
            main.Abort();
            Form1 mainscreen = new Form1();
            mainscreen.ShowDialog();
        }
        static void start()
        {
            Application.Run(new WelcomeForm());
        }

    }
}
