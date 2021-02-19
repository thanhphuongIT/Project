using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DA_QLDV
{
    public partial class Form_QLTaiKhoan : Form
    {
        public Form_QLTaiKhoan()
        {
            InitializeComponent();
        }
        LOGIN LG = new LOGIN();
        public void fillGrid(SqlCommand command)
        {
            DGrid.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DGrid.RowTemplate.Height = 80;
            DGrid.DataSource = LG.getTaikhoan(command);
            picCol = (DataGridViewImageColumn)DGrid.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DGrid.AllowUserToAddRows = false;
        }
        bool verif()
        {
            if ((txtUsername.Text.Trim() == "")
                || (txtPassword.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Form_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("Select Login.Username,Login.PassWord,Login.chidoan,Sinhvien.MSSV,Sinhvien.Hoten,Sinhvien.Picture " + 
            "From Login Inner Join Sinhvien On Login.chidoan = Sinhvien.CDoan and Sinhvien.Chucvu Like N'%Bí Thư%' where CanBo = 'Capchidoan'"));
        }

        private void DGrid_Click(object sender, EventArgs e)
        {
            txtUsername.Text = DGrid.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = DGrid.CurrentRow.Cells[1].Value.ToString();
            txtChiDoan.Text = DGrid.CurrentRow.Cells[2].Value.ToString();
            txtMSSV.Text = DGrid.CurrentRow.Cells[3].Value.ToString();
            txtHoTen.Text = DGrid.CurrentRow.Cells[4].Value.ToString();
            byte[] pic;
            pic = (byte[])DGrid.CurrentRow.Cells[5].Value;
            MemoryStream picture = new MemoryStream(pic);
            Picture.Image = Image.FromStream(picture);
        }

        
    }
}
