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
    public partial class Form_DanhGiaChiDoan : Form
    {
        public Form_DanhGiaChiDoan()
        {
            InitializeComponent();
        }
        NHANXET nhanxet = new NHANXET();
        public void fillGrid(SqlCommand command)
        {
            DGrid.ReadOnly = true;
            DGrid.RowTemplate.Height = 80;
            DGrid.DataSource = nhanxet.getNhanxet(command);
            DGrid.AllowUserToAddRows = false;
        }
        bool verif()
        {
            if ((txtHovaten.Text.Trim() == "")
                || (txtMSSV.Text.Trim() == "")
                || (txtManhanxet.Text.Trim() == "")
                || (txtUudiem.Text.Trim() == "")
                || (txtChidoan.Text.Trim() == "")
                || (cbxGioitinh.Text.Trim() == "")
                || (cbxChucvu.Text.Trim() == "")
                || (cbxXeploai.Text.Trim() == "")
                || (txtKhuyetdiem.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void DGrid_Click(object sender, EventArgs e)
        {
                txtManhanxet.Text = DGrid.CurrentRow.Cells[0].Value.ToString();
                txtMSSV.Text = DGrid.CurrentRow.Cells[1].Value.ToString();
                txtHovaten.Text = DGrid.CurrentRow.Cells[2].Value.ToString();
                txtChidoan.Text = DGrid.CurrentRow.Cells[3].Value.ToString();
                cbxGioitinh.Text = DGrid.CurrentRow.Cells[4].Value.ToString();
                cbxChucvu.Text = DGrid.CurrentRow.Cells[5].Value.ToString();
                txtUudiem.Text = DGrid.CurrentRow.Cells[6].Value.ToString();
                txtKhuyetdiem.Text = DGrid.CurrentRow.Cells[7].Value.ToString();
                cbxXeploai.Text = DGrid.CurrentRow.Cells[8].Value.ToString();
        }

        private void Form_DanhGiaChiDoan_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select NhanXet.MaNX,sinhvien.MSSV,sinhvien.Hoten,sinhvien.CDoan,Sinhvien.Gioitinh,Sinhvien.Chucvu, NhanXet.Uudiem, NhanXet.Khuyetdiem, NhanXet.Xeploai from Sinhvien INNER JOIN NhanXet ON NhanXet.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string manx = txtManhanxet.Text;
                if (MessageBox.Show("Bạn có chắc muốn xoá nhận xét này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (nhanxet.xoaNhanxet(manx))
                    {
                        MessageBox.Show("Nhận xét đã được xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtHovaten.Text = "";
                        txtMSSV.Text = "";
                        txtManhanxet.Text = "";
                        txtUudiem.Text = "";
                        txtChidoan.Text = "";
                        cbxGioitinh.Text = "";
                        cbxChucvu.Text = "";
                        cbxXeploai.Text = "";
                        txtKhuyetdiem.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá nhận xét!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chọn mã mã nhận xét cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid(new SqlCommand("select NhanXet.MaNX,sinhvien.MSSV,sinhvien.Hoten,sinhvien.CDoan,Sinhvien.Gioitinh,Sinhvien.Chucvu, NhanXet.Uudiem, NhanXet.Khuyetdiem, NhanXet.Xeploai from Sinhvien INNER JOIN NhanXet ON NhanXet.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manx;
            int madv = Convert.ToInt32(txtMSSV.Text);
            string chidoan = txtChidoan.Text;
            string uudiem = txtUudiem.Text;
            string khuyetdiem = txtKhuyetdiem.Text;
            string xeploai = cbxXeploai.Text;
            string namhoc = "";
            if (verif())
            {
                manx = txtManhanxet.Text;
                if (nhanxet.suaNhanxet(manx, madv, chidoan, uudiem, khuyetdiem, xeploai, namhoc))
                {
                    MessageBox.Show("Nhận xét đã được sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("select NhanXet.MaNX,sinhvien.MSSV,sinhvien.Hoten,sinhvien.CDoan,Sinhvien.Gioitinh,Sinhvien.Chucvu, NhanXet.Uudiem, NhanXet.Khuyetdiem, NhanXet.Xeploai from Sinhvien INNER JOIN NhanXet ON NhanXet.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));
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
            string manx = txtManhanxet.Text;
            int madv = Convert.ToInt32(txtMSSV.Text);
            string chidoan = txtChidoan.Text;
            string uudiem = txtUudiem.Text;
            string khuyetdiem = txtKhuyetdiem.Text;
            string xeploai = cbxXeploai.Text;
            string namhoc = "";
            if (verif())
            {
                if (nhanxet.themNhanxet(manx, madv, chidoan, uudiem, khuyetdiem, xeploai, namhoc))
                {
                    MessageBox.Show("Nhận xét đã được thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("select NhanXet.MaNX,sinhvien.MSSV,sinhvien.Hoten,sinhvien.CDoan,Sinhvien.Gioitinh,Sinhvien.Chucvu, NhanXet.Uudiem, NhanXet.Khuyetdiem, NhanXet.Xeploai from Sinhvien INNER JOIN NhanXet ON NhanXet.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "'"));
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
                SqlCommand command = new SqlCommand("select MSSV,Hoten,CDoan,Gioitinh,Chucvu From Sinhvien where MSSV =@madv ", db.getConnection);
                command.Parameters.Add("@madv", SqlDbType.Int).Value = Convert.ToInt32(txtMSSV.Text.ToString());
                adapter1.SelectCommand = command;
                adapter1.Fill(table1);
                DataRow dr = table1.Rows[0];
                if (dr["CDoan"].ToString() == Global.GlobalLop)
                {
                    txtHovaten.Text = dr["Hoten"].ToString();
                    txtChidoan.Text = dr["CDoan"].ToString();
                    cbxChucvu.Text = dr["Chucvu"].ToString();
                    cbxGioitinh.Text = dr["Gioitinh"].ToString();
                }
                else
                {
                    MessageBox.Show("Sinh viên không thuộc chi đoàn "+Global.GlobalLop, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
