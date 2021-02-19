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
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using App = Microsoft.Office.Interop.Excel.Application;

namespace DA_QLDV
{
    public partial class Form_XuatDanhSachDoanVienChuaDongDoanPhiChiDoan : Form
    {
        public Form_XuatDanhSachDoanVienChuaDongDoanPhiChiDoan()
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

        private void Form_XuatDanhSachDoanVienChuaDongDoanPhiChiDoan_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select * From(select Doanphi.MaDP, sinhvien.MSSV, sinhvien.Hoten, Sinhvien.Ngaysinh, sinhvien.CDoan, Doanphi.Sotien, Doanphi.Tinhtrang, Doanphi.Namhoc, sinhvien.Picture"
                +" FROM Sinhvien INNER JOIN Doanphi ON Doanphi.MaDV = Sinhvien.MSSV and Sinhvien.CDoan = '"+Global.GlobalLop+"') as Bangdoanphi where Bangdoanphi.Tinhtrang = N'Chưa nộp'"));
        }

        private void btnXuatdanhsach_Click(object sender, EventArgs e)
        {
            App app = new App();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.Columns.ColumnWidth = 25;
            for (int i = 1; i < DGrid.Columns.Count; i++)
            {
                app.Cells[1, i] = DGrid.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < DGrid.Rows.Count; i++)
            {
                for (int j = 0; j < DGrid.Columns.Count - 1; j++)
                {
                    if (DGrid.Rows[i].Cells[j].Value != null)
                    {
                        app.Cells[i + 2, j + 1] = DGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Danh sách đoàn viên chưa đóng đoàn phí";
            sfd.DefaultExt = ".xlsx";
            sfd.Filter = "Excel Format (*.xlsx)|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(sfd.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show("Bạn đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            app.Quit();
        }

        private void btnIndanhsach_Click(object sender, EventArgs e)
        {
            if (DGrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi: " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(DGrid.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in DGrid.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in DGrid.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dữ liệu Export thành công!!!", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Thông báo");
            }
        }
    }
}
