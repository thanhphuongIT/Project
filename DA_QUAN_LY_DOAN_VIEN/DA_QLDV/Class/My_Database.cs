using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DA_QLDV
{
    class My_Database
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H5G0EMB\SQLEXPRESS;Initial Catalog=Doanvien;Integrated Security=True");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void CloseConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
