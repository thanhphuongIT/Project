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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        public string Check()
        {
            if (rbtCapkhoa.Checked == true)
                return null;
            if (rbtCapchidoan.Checked == true)
                return cbxChidoan.Text.ToString();
            return null;
        }
        My_Database db = new My_Database();
        private void rbtCapkhoa_CheckedChanged(object sender, EventArgs e)
        {
            cbxChidoan.Enabled = false;
        }

        private void rbtCapchidoan_CheckedChanged(object sender, EventArgs e)
        {
            cbxChidoan.Enabled = true;
        }

        private void Form1_Login_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            DataTable table1 = new DataTable();
            SqlCommand command1 = new SqlCommand("SELECT MaCD FROM Chidoan", db.getConnection);
            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);
            cbxChidoan.DataSource = table1;
            cbxChidoan.DisplayMember = "MaCD";
            cbxChidoan.ValueMember = "MaCD";
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command;
            try
            {
                if (rbtCapchidoan.Checked == true)
                {
                    command = new SqlCommand("SELECT * FROM Login WHERE Username = @User AND PassWord = @Pass AND CanBo = @Canbo AND chidoan=@chidoan", db.getConnection);
                    command.Parameters.Add("@User", SqlDbType.Char).Value = TextBox_Username.Text;
                    command.Parameters.Add("@Pass", SqlDbType.Char).Value = TextBox_Password.Text;
                    command.Parameters.Add("@Canbo", SqlDbType.Char).Value = "Capchidoan";
                    command.Parameters.Add("@Chidoan", SqlDbType.Char).Value = cbxChidoan.Text;
                }
                else
                {
                    command = new SqlCommand("SELECT * FROM Login WHERE Username = @User AND PassWord = @Pass AND CanBo = @Canbo", db.getConnection);
                    command.Parameters.Add("@User", SqlDbType.Char).Value = TextBox_Username.Text;
                    command.Parameters.Add("@Pass", SqlDbType.Char).Value = TextBox_Password.Text;
                    command.Parameters.Add("@Canbo", SqlDbType.Char).Value = "Capkhoa";
                }
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    string check = Check();
                    if (check == null)
                    {
                        this.Hide();
                        Main Mn = new Main();
                        Mn.Show();
                        
                    }
                    else
                    {
                        this.Hide();
                        Global.SetGlobalLop(check);
                        Form_MainChiDoan CBChidoan = new Form_MainChiDoan();
                        CBChidoan.LABEL.Text = "CHI ĐOÀN " + check;
                        CBChidoan.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("Chú ý điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
