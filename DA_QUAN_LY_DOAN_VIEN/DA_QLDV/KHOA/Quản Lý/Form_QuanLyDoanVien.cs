using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DA_QLDV
{
    public partial class Form_QuanLyDoanVien : Form
    {
        DOANVIEN doanvien = new DOANVIEN();
        public Form_QuanLyDoanVien()
        {
            InitializeComponent();
        }
        //
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
        //
        bool verif()
        {
            if ((txtHoten.Text.Trim() == "")
                || (txtMssv.Text.Trim() == "")
                || (txtChucvu.Text.Trim() == "")
                || (txtCmnd.Text.Trim() == "")
                || (txtTrinhdo.Text.Trim() == "")
                || (txtTongiao.Text.Trim() == "")
                || (txtDantoc.Text.Trim() == "")
                || (txtChidoan.Text.Trim() == "")
                || (txtDiachi.Text.Trim() == "")
                || (picAnh.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                //
                int mssv = Convert.ToInt32(txtMssv.Text);
                string hoten = txtHoten.Text;
                string gioitinh = cbxGioitinh.Text;
                DateTime ngaysinh = DTNgaysinh.Value;
                DateTime ngayvaodoan = DTNgayvaodaon.Value;
                string chucvu = txtChucvu.Text;
                int cmnd = Convert.ToInt32(txtCmnd.Text);
                string hocvan = txtTrinhdo.Text;
                string tongiao = txtTongiao.Text;
                string dantoc = txtDantoc.Text;
                string chidoan = txtChidoan.Text;
                string diachi = txtDiachi.Text;
                MemoryStream pic = new MemoryStream();
                //
                int born_year = DTNgaysinh.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("Tuổi của đoàn viên chỉ nằm trong khoảng từ 14 đến 100 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //
                else if (verif())
                {
                    picAnh.Image.Save(pic, picAnh.Image.RawFormat);
                    if (doanvien.themDoanVien(mssv, hoten, gioitinh, ngaysinh, ngayvaodoan, chucvu, cmnd, hocvan,
                        tongiao, dantoc, chidoan, diachi, pic))
                    {
                        MessageBox.Show("Đoàn viên đã được thêm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT * FROM Sinhvien"));
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
            } catch
            {
                MessageBox.Show("Chú ý hãy điền chính xác tất cả thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form_Doanvien_Load(object sender, EventArgs e)
        {
            My_Database db = new My_Database();
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            DataTable table1 = new DataTable();
            SqlCommand command1 = new SqlCommand("SELECT MaCD FROM Chidoan", db.getConnection);
            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);
            txtChidoan.DataSource = table1;
            txtChidoan.DisplayMember = "MaCD";
            txtChidoan.ValueMember = "MaCD";
            fillGrid(new SqlCommand("SELECT * FROM Sinhvien"));
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opf = new OpenFileDialog();
            Opf.Filter = "Select Image(*.jpg;*.png;*.gift)|*.jpg;*.png;*.gift";
            if ((Opf.ShowDialog() == DialogResult.OK))
            {
                picAnh.Image = Image.FromFile(Opf.FileName);
                picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM Sinhvien"));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int mssv = Convert.ToInt32(txtMssv.Text);
                if (MessageBox.Show("Bạn có chắc muốn xoá đoàn viên này không?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (doanvien.xoaDoanVien(mssv))
                    {
                        MessageBox.Show("Sinh viên đã được xoá!", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMssv.Text = "";
                        txtHoten.Text = "";
                        cbxGioitinh.Text = comboNam.Text;
                        DTNgaysinh.Value = DateTime.Now;
                        DTNgayvaodaon.Value = DateTime.Now;
                        txtChucvu.Text = "";
                        txtCmnd.Text = "";
                        txtTrinhdo.Text = "12/12";
                        txtTongiao.Text = "";
                        txtDantoc.Text = "";
                        txtChidoan.Text = "";
                        txtDiachi.Text = "";
                        picAnh.Image = null;
                        
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá đoàn viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chọn đoàn viên cần xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid(new SqlCommand("SELECT * FROM Sinhvien"));


        }

        private void DGrid_Click(object sender, EventArgs e)
        {
            txtMssv.Text = DGrid.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = DGrid.CurrentRow.Cells[1].Value.ToString();
            if (DGrid.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                cbxGioitinh.Text = comboNam.Text;
            }
            if (DGrid.CurrentRow.Cells[2].Value.ToString() == "Nữ")
            {
                cbxGioitinh.Text = comboNu.Text;
            }

            DTNgaysinh.Value = (DateTime)DGrid.CurrentRow.Cells[3].Value;
            DTNgayvaodaon.Value = (DateTime)DGrid.CurrentRow.Cells[4].Value;
            txtChucvu.Text = DGrid.CurrentRow.Cells[5].Value.ToString();
            txtCmnd.Text = DGrid.CurrentRow.Cells[6].Value.ToString();
            txtTrinhdo.Text = DGrid.CurrentRow.Cells[7].Value.ToString();
            txtTongiao.Text = DGrid.CurrentRow.Cells[8].Value.ToString();
            txtDantoc.Text = DGrid.CurrentRow.Cells[9].Value.ToString();
            txtChidoan.Text = DGrid.CurrentRow.Cells[10].Value.ToString();
            txtDiachi.Text = DGrid.CurrentRow.Cells[11].Value.ToString();

            byte[] pic;
            pic = (byte[])DGrid.CurrentRow.Cells[12].Value;
            MemoryStream picture = new MemoryStream(pic);
            picAnh.Image = Image.FromStream(picture);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int mssv;
            string hoten = txtHoten.Text;
            DateTime ngaysinh = DTNgaysinh.Value;
            DateTime ngayvaodoan = DTNgayvaodaon.Value;
            string chucvu = txtChucvu.Text;
            int cmnd = Convert.ToInt32(txtCmnd.Text);
            string hocvan = txtTrinhdo.Text;
            string tongiao = txtTongiao.Text;
            string dantoc = txtDantoc.Text;
            string chidoan = txtChidoan.Text;
            string diachi = txtDiachi.Text;
            string gioitinh = comboNam.Text;
            if (cbxGioitinh.Text == comboNu.Text)
            {
                gioitinh = comboNu.Text;
            }
            MemoryStream pic = new MemoryStream();
            int born_year = DTNgaysinh.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 14) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("Tuổi của sinh viên chỉ nằm trong khoảng từ 14 đến 100 tuổi", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {

                    mssv = Convert.ToInt32(txtMssv.Text);
                    picAnh.Image.Save(pic, picAnh.Image.RawFormat);
                    if (doanvien.suaDoanVien(mssv, hoten, gioitinh, ngaysinh, ngayvaodoan, chucvu, cmnd, hocvan,
                        tongiao, dantoc, chidoan, diachi, pic))
                    {
                        MessageBox.Show("Đoàn viên đã được chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            fillGrid(new SqlCommand("SELECT * FROM Sinhvien"));
        }

        private void btnXuatdanhsach_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog() { Filter = "Text Document|.txt|Word Format|.doc|Excel Format|.xls", ValidateNames = true };

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                for (int i = 0; i < DGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < DGrid.Columns.Count -1; j++)
                    {
                        write.Write(DGrid.Rows[i].Cells[j].Value.ToString());
                        write.Write("\t\t");
                    }
                    write.WriteLine();
                }
                write.Dispose();
                MessageBox.Show("Bạn đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
