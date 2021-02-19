using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace DemoFlappyBird
{
    public partial class FormDiem : Form
    {
        public FormDiem()
        {
            InitializeComponent();
        }


        void LoadDiem()
        {
            //this.lsvDiem.Columns.Add("STT", 100, HorizontalAlignment.Left);
            this.lsvDiem.Columns.Add("Tên Người Chơi", 200, HorizontalAlignment.Center);
            this.lsvDiem.Columns.Add("Điểm", 100, HorizontalAlignment.Center);

            this.lsvDiem.FullRowSelect = true;
            this.lsvDiem.View = View.Details;

            FileInfo fp = new FileInfo("C:\\BXH.txt");
            if (!fp.Exists)
                MessageBox.Show("Tạo file mới", "Thông báo", MessageBoxButtons.OK);
            else
                ReadFile();
            
        }

        private void ReadFile()
        {
            FileStream fs = File.Open("C:\\BXH.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs);
            NguoiChoi nc;
            string line="";
            int Diem=0;
            string HvT="";
            while((line = sr.ReadLine())!=null)
            {
                CatChuoi(line,ref HvT,ref Diem);
                nc = new NguoiChoi(HvT, Diem);
                ListViewItem lvi = new ListViewItem(nc.Hovaten.ToString().ToUpper());
                lvi.SubItems.Add(nc.diem.ToString());
                this.lsvDiem.Items.Add(lvi);
                HvT = "";
            }
            sr.Close();
            fs.Close();

        }

        private void CatChuoi(string line, ref string s1, ref int i2)
        {
            string s2 = "";
            int i = 0;
            foreach (var item in line)
            {
                i++;
                if (item == '-')
                    break;
                s1 += item;
            }
            for (int j = i + 1; j < line.Length; j++)
            {
                i++;
                if (line[j] == '-')
                    break;
                if (char.IsDigit(line[j]))//kiểm tra xem có phải là hệ cơ số 10 hay không.
                    s2 += (char)line[j];
                i2 = int.Parse(s2);
            }
        }

        private void FormDiem_Load(object sender, EventArgs e)
        {
            LoadDiem();
        }

        private void lsvDiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
