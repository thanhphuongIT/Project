using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_QLDV
{
    public partial class Form_Login : Form
    {
        My_Database db = new My_Database();
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Button_DangNhap_Click(object sender, EventArgs e)
        {      
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE Username = @User AND PassWord = @Pass AND CanBo = @Canbo", db.getConnection);
            command.Parameters.Add("@User", SqlDbType.Char).Value = TextBox_Username.Text;
            command.Parameters.Add("@Pass", SqlDbType.Char).Value = TextBox_Password.Text;
            if (CheckBox_Canbochidoan.Checked == true)
            {
                command.Parameters.Add("@Canbo", SqlDbType.Char).Value = "Capchidoan";
            }
            if (CheckBox_Canbokhoa.Checked == true)
            {
                command.Parameters.Add("@Canbo", SqlDbType.Char).Value = "Capkhoa";
            }
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private void CheckBox_Canbokhoa_Click(object sender, EventArgs e)
        {
            if (CheckBox_Canbochidoan.Enabled == true)
            {
                CheckBox_Canbochidoan.Enabled = false;
                ComboBox_Canbochidoan.Enabled = false;
            }
            else
            {
                CheckBox_Canbochidoan.Enabled = true;
                ComboBox_Canbochidoan.Enabled = true;
            }
        }

        private void CheckBox_Canbochidoan_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Canbokhoa.Enabled == true)
            {
                CheckBox_Canbokhoa.Enabled = false;
            }
            else
            {
                CheckBox_Canbokhoa.Enabled = true;
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            DataTable table1 = new DataTable();
            SqlCommand command1 = new SqlCommand("SELECT MaCD FROM Chidoan", db.getConnection);
            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);
            ComboBox_Canbochidoan.DataSource = table1;
            ComboBox_Canbochidoan.DisplayMember = "MaCD";
            ComboBox_Canbochidoan.ValueMember = "MaCD";
            
        }
    }
}
