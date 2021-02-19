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
    public partial class Form_TaoTaiKhoan : Form
    {
        public Form_TaoTaiKhoan()
        {
            InitializeComponent();
        }


        private void Form_TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            My_Database db = new My_Database();
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            DataTable table1 = new DataTable();
            SqlCommand command1 = new SqlCommand("SELECT MaCD FROM Chidoan", db.getConnection);
            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);
            cbxChidoan.DataSource = table1;
            cbxChidoan.DisplayMember = "MaCD";
            cbxChidoan.ValueMember = "MaCD";
        }

        private void btnTaotaikhoan_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            string cbo = null;
            string chidoan = null;
            if (rbtCapchidoan.Checked == true)
            {
                cbo = "Capchidoan";
                chidoan = cbxChidoan.Text;
            }
            else if (rbtCapkhoa.Checked == true)
            {
                cbo = "Capkhoa";
                chidoan = null;
            }
            try
            {
                if (verif())
                {
                    if (txtPassword.Text == txtPassword_lai.Text)
                    {
                        if (lg.themTaikhoan(user, pass, cbo, chidoan))
                        {
                            MessageBox.Show("Đã tạo mới tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Tạo tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại chính xác Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        bool verif()
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "" ||
                cbxChidoan.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void rbtCapchidoan_CheckedChanged(object sender, EventArgs e)
        {
            cbxChidoan.Enabled = true;
        }

        private void rbtCapkhoa_CheckedChanged(object sender, EventArgs e)
        {
            cbxChidoan.Enabled = false;
        }
    }
}
