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
    public partial class Form_TimKiemDoanVienChuaDongDoanPhiChiDoan : Form
    {
        public Form_TimKiemDoanVienChuaDongDoanPhiChiDoan()
        {
            InitializeComponent();
        }
        DOANPHI doanphi = new DOANPHI();
        public void fillGrid(SqlCommand command)
        {
            DGrid.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DGrid.RowTemplate.Height = 80;
            DGrid.DataSource = doanphi.getDoanphi(command);
            picCol = (DataGridViewImageColumn)DGrid.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DGrid.AllowUserToAddRows = false;
        }

        private void Form_TimKiemDoanVienChuaDongDoanPhiChiDoan_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select * From(select Doanphi.MaDP, sinhvien.MSSV, sinhvien.Hoten, Sinhvien.Ngaysinh, sinhvien.CDoan, Doanphi.Sotien, Doanphi.Tinhtrang, Doanphi.Namhoc, sinhvien.Picture " +
                           "FROM Sinhvien INNER JOIN Doanphi ON Doanphi.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "') as Bangdoanphi where Bangdoanphi.Tinhtrang = N'Chưa nộp'"));
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select * From(select Doanphi.MaDP, sinhvien.MSSV, sinhvien.Hoten, Sinhvien.Ngaysinh, sinhvien.CDoan, Doanphi.Sotien, Doanphi.Tinhtrang, Doanphi.Namhoc, sinhvien.Picture " +
                           "FROM Sinhvien INNER JOIN Doanphi ON Doanphi.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "') as Bangdoanphi where Bangdoanphi.Tinhtrang = N'Chưa nộp'"));
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            My_Database mydb = new My_Database();
            string cmd = "(select Doanphi.MaDP, sinhvien.MSSV, sinhvien.Hoten, Sinhvien.Ngaysinh, sinhvien.CDoan, Doanphi.Sotien, Doanphi.Tinhtrang, Doanphi.Namhoc, sinhvien.Picture " +
                            "FROM Sinhvien INNER JOIN Doanphi ON Doanphi.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '" + Global.GlobalLop + "') as Bangdoanphi where Bangdoanphi.Tinhtrang = N'Chưa nộp'";
            if (rbtTen.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " and Bangdoanphi.Hoten like N'%" + txtTimkiem.Text + "%'"));
            }
            else if (rbtMssv.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " and Bangdoanphi.MSSV like N'%" + Convert.ToInt32(txtTimkiem.Text) + "%'"));
            }
            else if (rbtChidoan.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " and Bangdoanphi.Cdoan like N'%" + txtTimkiem.Text + "%'"));
            }
            else if (rbtNamhoc.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT  * FROM " + cmd + " and Bangdoanphi.Namhoc like N'%" + txtTimkiem.Text + "%'"));
            }
        }
    }
}
