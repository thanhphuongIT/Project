using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFlappyBird
{
    public partial class FormTenNC : Form
    {
        public FormTenNC()
        {
            InitializeComponent();
        }

        public string Tenngchoi = "";
        

        private void btnVao_Click(object sender, EventArgs e)
        {
            if(txbTenNguoiChoi.Text.Length < 3)
            {
                MessageBox.Show("Bạn cần nhập tên người chơi lớn hơn 3 kí tự","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTenNguoiChoi.Clear();
                txbTenNguoiChoi.Focus();
            }
            else
            {
                Tenngchoi = txbTenNguoiChoi.Text.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnVao_MouseMove(object sender, MouseEventArgs e)
        {
            btnVao.BackColor = Color.SkyBlue;
            btnVao.ForeColor = Color.DarkRed;
        }

        private void btnVao_MouseLeave(object sender, EventArgs e)
        {
            btnVao.BackColor = Color.Transparent;
            btnVao.ForeColor = Color.Black;
        }

        private void btnThoat_MouseMove(object sender, MouseEventArgs e)
        {
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.ForeColor = Color.DarkRed;
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Transparent;
            btnThoat.ForeColor = Color.Black;
        }
    }
}
