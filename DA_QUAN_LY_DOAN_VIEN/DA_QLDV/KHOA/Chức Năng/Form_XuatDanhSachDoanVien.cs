using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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
    public partial class Form_XuatDanhSachDoanVien : Form
    {
        public Form_XuatDanhSachDoanVien()
        {
            InitializeComponent();
        }
        DOANVIEN doanvien = new DOANVIEN();
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
            sfd.FileName = "Danh sách đoàn viên";
            sfd.DefaultExt = ".xlsx";
            sfd.Filter = "Excel Format (*.xlsx)|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(sfd.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show("Bạn đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            app.Quit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objbmp = new Bitmap(this.DGrid.Width, this.DGrid.Height);
            DGrid.DrawToBitmap(objbmp, new System.Drawing.Rectangle(0, 0, this.DGrid.Width, this.DGrid.Height));
            e.Graphics.DrawImage(objbmp, 0, 140);
            e.Graphics.DrawString("DANH SÁCH ĐOÀN VIÊN", new System.Drawing.Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(250, 60));
        }

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

        private void Form_XuatDanhSachDoanVien_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM Sinhvien"));
        }

        private void btnTimkiem_Click_1(object sender, EventArgs e)
        {
            My_Database mydb = new My_Database();
            if (rbtGioitinh.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT * FROM Sinhvien WHERE Gioitinh LIKE N'%" + txtTimkiem.Text + "%'"));
            }
            else if (rbtChucvu.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT * FROM Sinhvien WHERE Chucvu LIKE N'%" + txtTimkiem.Text + "%'"));
            }
            else if (rbtChidoan.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT * FROM Sinhvien WHERE Cdoan LIKE N'%" + txtTimkiem.Text + "%'"));
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM Sinhvien"));

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

