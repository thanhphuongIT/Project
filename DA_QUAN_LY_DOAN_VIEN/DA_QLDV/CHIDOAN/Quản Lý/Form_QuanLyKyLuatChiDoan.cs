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
    public partial class Form_QuanLyKyLuatChiDoan : Form
    {
        public Form_QuanLyKyLuatChiDoan()
        {
            InitializeComponent();
        }
        KYLUAT kldv = new KYLUAT();
        //
        public void fillGrid(SqlCommand command)
        {
            DGrid.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DGrid.RowTemplate.Height = 80;
            DGrid.DataSource = kldv.getKyluat(command);
            picCol = (DataGridViewImageColumn)DGrid.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DGrid.AllowUserToAddRows = false;
        }
        bool verif()
        {
            if ((txtHoten.Text.Trim() == "")
                || (txtMakyluat.Text.Trim() == "")
                || (txtMSSV.Text.Trim() == "")
                || (txtHoten.Text.Trim() == "")
                || (txtChidoan.Text.Trim() == "")
                || (txtHinhthuc.Text.Trim() == "")
                || (txtLoaivipham.Text.Trim() == "")
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makl = txtMakyluat.Text;
            int madv = Convert.ToInt32(txtMSSV.Text);
            string cdoan = txtChidoan.Text;
            string loaivipham = txtLoaivipham.Text;
            string hinhthuc = txtHinhthuc.Text;
            string namhoc = txtNamhoc.Text;
            if (verif())
            {
                if (kldv.themKyluat(makl, madv, cdoan, loaivipham, hinhthuc, namhoc))
                {
                    MessageBox.Show("Kỷ luật đã được thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("select KyLuat.MaKL,sinhvien.MSSV,sinhvien.Hoten,Sinhvien.Ngaysinh,sinhvien.CDoan,KyLuat.Loaivipham,KyLuat.Hinhthuc,KyLuat.Namhoc,sinhvien.Picture from Sinhvien INNER JOIN KyLuat ON KyLuat.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makl;
            int madv = Convert.ToInt32(txtMSSV.Text);
            string cdoan = txtChidoan.Text;
            string loaivipham = txtLoaivipham.Text;
            string hinhthuc = txtHinhthuc.Text;
            string namhoc = txtNamhoc.Text;
            if (verif())
            {
                makl = txtMakyluat.Text;
                if (kldv.suaKyluat(makl, madv, cdoan, loaivipham, hinhthuc, namhoc))
                {
                    MessageBox.Show("Kỷ luật đã được sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("select KyLuat.MaKL,sinhvien.MSSV,sinhvien.Hoten,Sinhvien.Ngaysinh,sinhvien.CDoan,KyLuat.Loaivipham,KyLuat.Hinhthuc,KyLuat.Namhoc,sinhvien.Picture from Sinhvien INNER JOIN KyLuat ON KyLuat.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string makl = txtMakyluat.Text;
                if (MessageBox.Show("Bạn có chắc muốn xoá kỷ luật này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (kldv.xoaKyLuat(makl))
                    {
                        MessageBox.Show("Kỷ luật đã được xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMakyluat.Text = "";
                        txtMSSV.Text = "";
                        txtHoten.Text = "";
                        datetimeNgaysinh.Value = DateTime.Now;
                        txtChidoan.Text = "";
                        txtLoaivipham.Text = "";
                        txtHinhthuc.Text = "";
                        txtNamhoc.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá kỷ luật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chọn mã kỷ luật cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid(new SqlCommand("select KyLuat.MaKL,sinhvien.MSSV,sinhvien.Hoten,Sinhvien.Ngaysinh,sinhvien.CDoan,KyLuat.Loaivipham,KyLuat.Hinhthuc,KyLuat.Namhoc,sinhvien.Picture from Sinhvien INNER JOIN KyLuat ON KyLuat.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));
        }

        private void bntLoc_Click(object sender, EventArgs e)
        {
            My_Database mydb = new My_Database();
            string cmd = "(select KyLuat.MaKL,sinhvien.MSSV,sinhvien.Hoten,Sinhvien.Ngaysinh,sinhvien.CDoan,KyLuat.Loaivipham,KyLuat.Hinhthuc,KyLuat.Namhoc,sinhvien.Picture from Sinhvien INNER JOIN KyLuat ON KyLuat.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "') as Bangkyluat";
            if (rbtTen.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " WHERE Bangkyluat.Hoten like N'%" + txtLoc.Text + "%'"));
            }
            else if (rbtMSSV.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " WHERE Bangkyluat.MSSV like N'%" + Convert.ToInt32(txtLoc.Text) + "%'"));
            }
            else if (rbtChidoan.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " WHERE Bangkyluat.Cdoan like N'%" + txtLoc.Text + "%'"));
            }
            else if (rbtHinhthuc.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " WHERE Bangkyluat. Hinhthuc like N'%" + txtLoc.Text + "%'"));
            }
            else if (rbtVipham.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " WHERE Bangkyluat.LoaiVipham like N'%" + txtLoc.Text + "%'"));
            }
            else if (rbtNamhoc.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " WHERE Bangkyluat.Namhoc like N'%" + txtLoc.Text + "%'"));
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select KyLuat.MaKL,sinhvien.MSSV,sinhvien.Hoten,Sinhvien.Ngaysinh,sinhvien.CDoan,KyLuat.Loaivipham,KyLuat.Hinhthuc,KyLuat.Namhoc,sinhvien.Picture from Sinhvien INNER JOIN KyLuat ON KyLuat.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));

        }

        private void Form_QuanLyKyLuatChiDoan_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select KyLuat.MaKL,sinhvien.MSSV,sinhvien.Hoten,Sinhvien.Ngaysinh,sinhvien.CDoan,KyLuat.Loaivipham,KyLuat.Hinhthuc,KyLuat.Namhoc,sinhvien.Picture from Sinhvien INNER JOIN KyLuat ON KyLuat.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));

        }

        private void DGrid_Click(object sender, EventArgs e)
        {
            txtMakyluat.Text = DGrid.CurrentRow.Cells[0].Value.ToString();
            txtMSSV.Text = DGrid.CurrentRow.Cells[1].Value.ToString();
            txtHoten.Text = DGrid.CurrentRow.Cells[2].Value.ToString();
            datetimeNgaysinh.Value = (DateTime)DGrid.CurrentRow.Cells[3].Value;
            txtChidoan.Text = DGrid.CurrentRow.Cells[4].Value.ToString();
            txtLoaivipham.Text = DGrid.CurrentRow.Cells[5].Value.ToString();
            txtHinhthuc.Text = DGrid.CurrentRow.Cells[6].Value.ToString();
            txtNamhoc.Text = DGrid.CurrentRow.Cells[7].Value.ToString();
            byte[] pic;
            pic = (byte[])DGrid.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            picAnh.Image = Image.FromStream(picture);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
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
    }
}
