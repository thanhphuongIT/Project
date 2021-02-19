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
    public partial class Form_ThongKeGioiTinhDoanVien : Form
    {
        public Form_ThongKeGioiTinhDoanVien()
        {
            InitializeComponent();
        }
        DOANVIEN doanvien = new DOANVIEN();

        private void Form_ThongKeGioiTinhDoanVien_Load(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(doanvien.totalDoanvien());
            double Nam = Convert.ToDouble(doanvien.totalNam());
            double Nu = Convert.ToDouble(doanvien.totalNu());
            double Tilenam = (Nam * (100 / total));
            double Tilenu = (Nu * (100 / total));
            ChartPie.Series["Biểu Đồ"].Points.AddXY("Nam  " + Tilenam.ToString("0.00") + "%", Tilenam);
            ChartPie.Series["Biểu Đồ"].Points.AddXY("Nữ   " + Tilenu.ToString("0.00") + "%", Tilenu);
        }
    }
}
