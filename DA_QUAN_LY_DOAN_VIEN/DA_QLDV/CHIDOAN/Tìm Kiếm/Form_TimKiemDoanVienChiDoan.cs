using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_QLDV
{
    public partial class Form_TimKiemDoanVienChiDoan : Form
    {
        public Form_TimKiemDoanVienChiDoan()
        {
            InitializeComponent();
        }
        DOANVIEN doanvien = new DOANVIEN();
        My_Database db = new My_Database();
        public void fillGrid(SqlCommand command)
        {
            DGrid.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DGrid.RowTemplate.Height = 80;
            DGrid.DataSource = doanvien.getDoanvien(command);
            picCol = (DataGridViewImageColumn)DGrid.Columns[12];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DGrid.AllowUserToAddRows = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            My_Database mydb = new My_Database();
            if (rbtTen.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT *FROM Sinhvien WHERE CDoan = '" + Global.GlobalLop + "' and Hoten like N'% " + txtTimkiem.Text + "%'"));
            }
            else if (rbtMssv.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT * FROM Sinhvien WHERE CDoan = '" + Global.GlobalLop + "' and MSSV LIKE N'%" + txtTimkiem.Text + "%'"));
            }
            else if (rbtGioitinh.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT * FROM Sinhvien WHERE CDoan = '" + Global.GlobalLop + "' and Gioitinh LIKE N'%" + txtTimkiem.Text + "%'"));
            }
            else if (rbtChucvu.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT * FROM Sinhvien WHERE CDoan = '" + Global.GlobalLop + "' and Chucvu LIKE N'%" + txtTimkiem.Text + "%'"));
            }
            else if (rbtChidoan.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT * FROM Sinhvien WHERE CDoan = '" + Global.GlobalLop + "' and Cdoan LIKE N'%" + txtTimkiem.Text + "%'"));
            }
        }

        private void Form_TimKiemDoanVienChiDoan_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM Sinhvien Where CDoan = '" + Global.GlobalLop + "'"));
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM Sinhvien Where CDoan = '" + Global.GlobalLop + "'"));
        }
    }
}
