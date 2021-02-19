﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_QLDV
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
            //Application.Run(new Form_Login());
            Form_Login flogin = new Form_Login();
            if (flogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main());
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
