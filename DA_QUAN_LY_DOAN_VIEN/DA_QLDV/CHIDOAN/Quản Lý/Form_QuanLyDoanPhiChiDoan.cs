using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DA_QLDV
{
    public partial class Form_QuanLyDoanPhiChiDoan : Form
    {
        DOANPHI doanphi = new DOANPHI();
        public Form_QuanLyDoanPhiChiDoan()
        {
            InitializeComponent();
        }
        public void fillGrid(SqlCommand command)
        {
            DataGrid.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGrid.RowTemplate.Height = 80;
            DataGrid.DataSource = doanphi.getDoanphi(command);
            picCol = (DataGridViewImageColumn)DataGrid.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGrid.AllowUserToAddRows = false;
        }
        bool verif()
        {
            if ((txtHoten.Text.Trim() == "")
                || (txtSotien.Text.Trim() == "")
                || (txtMSSV.Text.Trim() == "")
                || (txtHoten.Text.Trim() == "")
                || (txtSotien.Text.Trim() == "")
                || (txtChidoan.Text.Trim() == "")
                || (cbxTinhtrang.Text.Trim() == "")
                || (txtNamhoc.Text.Trim() == "")
                || (picAnh.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void DataGrid_Click(object sender, EventArgs e)
        {
            txtMadoanphi.Text = DataGrid.CurrentRow.Cells[0].Value.ToString();
            txtMSSV.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
            txtHoten.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
            datetimeNgaysinh.Value = (DateTime)DataGrid.CurrentRow.Cells[3].Value;
            txtChidoan.Text = DataGrid.CurrentRow.Cells[4].Value.ToString();
            txtSotien.Text = DataGrid.CurrentRow.Cells[5].Value.ToString();
            cbxTinhtrang.Text = DataGrid.CurrentRow.Cells[6].Value.ToString();
            txtNamhoc.Text = DataGrid.CurrentRow.Cells[7].Value.ToString();
            byte[] pic;
            pic = (byte[])DataGrid.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            picAnh.Image = Image.FromStream(picture);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select Doanphi.MaDP,sinhvien.MSSV,sinhvien.Hoten,Sinhvien.Ngaysinh,sinhvien.CDoan,Doanphi.Sotien,Doanphi.Tinhtrang,Doanphi.Namhoc,sinhvien.Picture from Sinhvien INNER JOIN Doanphi ON Doanphi.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '"+Global.GlobalLop+"'"));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string madp = txtMadoanphi.Text;
                if (MessageBox.Show("Bạn có chắc muốn xoá đoàn phí này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (doanphi.xoaDoanphi(madp))
                    {
                        MessageBox.Show("Đoàn phí đã được xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMadoanphi.Text = "";
                        txtMSSV.Text = "";
                        txtHoten.Text = "";
                        datetimeNgaysinh.Value = DateTime.Now;
                        txtChidoan.Text = "";
                        txtSotien.Text = "";
                        cbxTinhtrang.Text = "";
                        txtNamhoc.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá đoàn phí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chọn mã đoàn phí cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid(new SqlCommand("select Doanphi.MaDP,sinhvien.MSSV,sinhvien.Hoten,Sinhvien.Ngaysinh,sinhvien.CDoan,Doanphi.Sotien,Doanphi.Tinhtrang,Doanphi.Namhoc,sinhvien.Picture from Sinhvien INNER JOIN Doanphi ON Doanphi.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string madp;
            int madv = Convert.ToInt32(txtMSSV.Text);
            int sotien = Convert.ToInt32(txtSotien.Text);
            string tinhtrang = cbxTinhtrang.Text;
            string namhoc = txtNamhoc.Text;
            if (verif())
            {
                madp = txtMadoanphi.Text;
                if (doanphi.suaDoanphi(madp, madv, sotien, tinhtrang, namhoc))
                {
                    MessageBox.Show("Đoàn phí đã được sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("select Doanphi.MaDP,sinhvien.MSSV,sinhvien.Hoten,Sinhvien.Ngaysinh,sinhvien.CDoan,Doanphi.Sotien,Doanphi.Tinhtrang,Doanphi.Namhoc,sinhvien.Picture from Sinhvien INNER JOIN Doanphi ON Doanphi.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Có ô còn bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string madp = txtMadoanphi.Text;
            int madv = Convert.ToInt32(txtMSSV.Text);
            int sotien = Convert.ToInt32(txtSotien.Text);
            string tinhtrang = cbxTinhtrang.Text;
            string namhoc = txtNamhoc.Text;
            if (verif())
            {
                if (doanphi.themDoanphi(madp, madv, sotien, tinhtrang, namhoc))
                {
                    MessageBox.Show("Đoàn phí đã được thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("select Doanphi.MaDP,sinhvien.MSSV,sinhvien.Hoten,Sinhvien.Ngaysinh,sinhvien.CDoan,Doanphi.Sotien,Doanphi.Tinhtrang,Doanphi.Namhoc,sinhvien.Picture from Sinhvien INNER JOIN Doanphi ON Doanphi.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Thông báot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Có ô còn bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtMSSV_Leave(object sender, EventArgs e)
        {
            try
            {
                My_Database db = new My_Database();
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                DataTable table1 = new DataTable();
                SqlCommand command = new SqlCommand("select MSSV,Hoten,Ngaysinh,CDoan,Picture From Sinhvien where MSSV =@madv ", db.getConnection);
                command.Parameters.Add("@madv", SqlDbType.Int).Value = Convert.ToInt32(txtMSSV.Text.ToString());
                adapter1.SelectCommand = command;
                adapter1.Fill(table1);
                DataRow dr = table1.Rows[0];
                if (dr["CDoan"].ToString() == Global.GlobalLop)
                {
                    txtHoten.Text = dr["Hoten"].ToString();
                    txtChidoan.Text = dr["CDoan"].ToString();
                    datetimeNgaysinh.Value = Convert.ToDateTime(dr["Ngaysinh"].ToString());
                    byte[] pic;
                    pic = (byte[])dr["Picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    picAnh.Image = Image.FromStream(picture);
                    picAnh.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    MessageBox.Show("Sinh viên không thuộc chi đoàn " + Global.GlobalLop, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMSSV.Text = "";
                } 
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập chính xác MSSV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntLoc_Click(object sender, EventArgs e)
        {
            My_Database mydb = new My_Database();
            string cmd = "(select Doanphi.MaDP,sinhvien.MSSV,sinhvien.Hoten,Sinhvien.Ngaysinh,sinhvien.CDoan,Doanphi.Sotien,Doanphi.Tinhtrang,Doanphi.Namhoc,sinhvien.Picture from Sinhvien INNER JOIN Doanphi ON Doanphi.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "') as Bangdoanphi";
            if (rbtTen.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " WHERE Bangdoanphi.Hoten like N'%" + txtLoc.Text + "%'"));
            }
            else if (rbtMSSV.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " WHERE Bangdoanphi.MSSV like N'%" + Convert.ToInt32(txtLoc.Text) + "%'"));
            }
            else if (rbtChidoan.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " WHERE Bangdoanphi.Cdoan like N'%" + txtLoc.Text + "%'"));
            }
            else if (rbtTinhtrang.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " WHERE Bangdoanphi.Tinhtrang like N'%" + txtLoc.Text + "%'"));
            }
            else if (rbtNamhoc.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " WHERE Bangdoanphi.Namhoc like N'%" + txtLoc.Text + "%'"));
            }

        }
        private void Form_QuanLyDoanPhiChiDoan_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select Doanphi.MaDP,sinhvien.MSSV,sinhvien.Hoten,Sinhvien.Ngaysinh,sinhvien.CDoan,Doanphi.Sotien,Doanphi.Tinhtrang,Doanphi.Namhoc,sinhvien.Picture from Sinhvien INNER JOIN Doanphi ON Doanphi.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));
        }
    }
}
