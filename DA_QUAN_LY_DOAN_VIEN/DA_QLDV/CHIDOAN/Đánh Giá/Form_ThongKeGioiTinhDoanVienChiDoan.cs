using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DA_QLDV
{
    public partial class Form_ThongKeGioiTinhDoanVienChiDoan : Form
    {
        public Form_ThongKeGioiTinhDoanVienChiDoan()
        {
            InitializeComponent();
        }
        DOANVIEN doanvien = new DOANVIEN();

        private void Form_ThongKeGioiTinhDoanVienChiDoan_Load(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(doanvien.totalDoanvienchidoan());
            double Nam = Convert.ToDouble(doanvien.totalNamchidoan());
            double Nu = Convert.ToDouble(doanvien.totalNuchidoan());
            double Tilenam = (Nam * (100 / total));
            double Tilenu = (Nu * (100 / total));
            ChartPie.Series["Biểu Đồ"].Points.AddXY("Nam  " + Tilenam.ToString("0.00") + "%", Tilenam);
            ChartPie.Series["Biểu Đồ"].Points.AddXY("Nữ   " + Tilenu.ToString("0.00") + "%", Tilenu);
        }
    }
}
