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
    public partial class Form_ThongKeXepLoaiDoanVien : Form
    {
        public Form_ThongKeXepLoaiDoanVien()
        {
            InitializeComponent();
        }
        NHANXET nhanxet = new NHANXET();
        DOANVIEN doanvien = new DOANVIEN();
        private void Form_ThongKeXepLoaiDoanVien_Load(object sender, EventArgs e)
        {
            double tongsodoanvien = Convert.ToDouble(doanvien.totalDoanvien());
            double total = Convert.ToDouble(nhanxet.totalNhanxet());
            double Chuatot = Convert.ToDouble(nhanxet.totalChuatot());
            double Tot = Convert.ToDouble(nhanxet.totalTot());
            double Chuadanhgia = tongsodoanvien - total;
            double Tilechuatot = (Chuatot * (100 / tongsodoanvien));
            double Tiletot = (Tot * (100 / tongsodoanvien));
            double Tilechuadanhgia = (Chuadanhgia * (100 / tongsodoanvien));
            if (Tilechuatot == 0 && Tiletot == 0)
            {
                ChartPie.Series["Biểu Đồ"].Points.AddXY("Chưa Đánh Giá  " + Tilechuadanhgia.ToString("0.00") + "%", Tilechuadanhgia);
            }
            else if (Tilechuatot == 0 && Tilechuadanhgia == 0)
            {
                ChartPie.Series["Biểu Đồ"].Points.AddXY("Tốt  " + Tiletot.ToString("0.00") + "%", Tiletot);

            }
            else if (Tiletot == 0 && Tilechuadanhgia == 0)
            {
                ChartPie.Series["Biểu Đồ"].Points.AddXY("Chưa Tốt  " + Tilechuatot.ToString("0.00") + "%", Tilechuatot);
            }
            else if (Tilechuatot > 0 && Tiletot == 0)
            {
                ChartPie.Series["Biểu Đồ"].Points.AddXY("Chưa Tốt  " + Tilechuatot.ToString("0.00") + "%", Tilechuatot);
                ChartPie.Series["Biểu Đồ"].Points.AddXY("Chưa Đánh Giá  " + Tilechuadanhgia.ToString("0.00") + "%", Tilechuadanhgia);
            }
            else if (Tilechuatot == 0 && Tiletot > 0)
            {
                ChartPie.Series["Biểu Đồ"].Points.AddXY("Tốt  " + Tiletot.ToString("0.00") + "%", Tiletot);
                ChartPie.Series["Biểu Đồ"].Points.AddXY("Chưa Đánh Giá  " + Tilechuadanhgia.ToString("0.00") + "%", Tilechuadanhgia);
            }
            else if (Tilechuatot > 0 && Tiletot > 0 && Tilechuadanhgia == 0)
            {
                ChartPie.Series["Biểu Đồ"].Points.AddXY("Chưa Tốt  " + Tilechuatot.ToString("0.00") + "%", Tilechuatot);
                ChartPie.Series["Biểu Đồ"].Points.AddXY("Tốt  " + Tiletot.ToString("0.00") + "%", Tiletot);
            }
            else
            {
                ChartPie.Series["Biểu Đồ"].Points.AddXY("Chưa Tốt  " + Tilechuatot.ToString("0.00") + "%", Tilechuatot);
                ChartPie.Series["Biểu Đồ"].Points.AddXY("Tốt  " + Tiletot.ToString("0.00") + "%", Tiletot);
                ChartPie.Series["Biểu Đồ"].Points.AddXY("Chưa Đánh Giá  " + Tilechuadanhgia.ToString("0.00") + "%", Tilechuadanhgia);
            }
        }
    }
}
