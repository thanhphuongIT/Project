using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DA_QLDV
{
    public partial class Form_Huongdan : Form
    {
        public Form_Huongdan()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            MDAvideo.URL = "Video.mp4";
            MDAvideo.Ctlcontrols.play();
        }

        private void btndung_Click(object sender, EventArgs e)
        {
            MDAvideo.Ctlcontrols.stop();
        }

        private void btntamdung_Click(object sender, EventArgs e)
        {
            MDAvideo.Ctlcontrols.pause();
        }
    }
}
