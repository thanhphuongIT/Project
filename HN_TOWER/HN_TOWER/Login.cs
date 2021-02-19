using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HN_TOWER
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "admin") DialogResult = DialogResult.OK;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
