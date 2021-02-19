using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DA_QLDV
{
    public partial class Form_DoiMatKhauChiDoan : Form
    {
        public Form_DoiMatKhauChiDoan()
        {
            InitializeComponent();
        }
        My_Database db = new My_Database();
        LOGIN lg = new LOGIN();
        bool verif()
        {
            if (txtUsername_cu.Text.Trim() == "" || txtPassword_cu.Text.Trim() == "" ||
                txtPassword_Lai.Text.Trim() == "" || txtPassword_Lai.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtDoimatkhau_Click(object sender, EventArgs e)
        {
            string user = txtUsername_cu.Text.ToString();
            string pass_cu = txtPassword_cu.Text.ToString();
            try
            {
                if (verif())
                {
                    string pass_moi = txtPassword_Lai.Text.ToString();
                    if (lg.Doimatkhau(user, pass_cu, pass_moi))
                    {
                        MessageBox.Show("Mật khẩu đã được đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Có ô còn bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Chú ý điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
