using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DA_QLDV
{
    class LOGIN
    {
        My_Database mydb = new My_Database();
        // Thêm
        public bool themTaikhoan(string username, string password, string canbo, string chidoan)
        {
            SqlCommand command;
            if (chidoan == null)
            {
                command = new SqlCommand("INSERT INTO Login (Username, PassWord, CanBo,chidoan)" +
                    "VALUES (@username, @password,@canbo,@chidoan)", mydb.getConnection);
                command.Parameters.Add("@username", SqlDbType.Char).Value = username;
                command.Parameters.Add("@password", SqlDbType.Char).Value = password;
                command.Parameters.Add("@canbo", SqlDbType.Char).Value = canbo;
                command.Parameters.Add("@chidoan", SqlDbType.Char).Value = "";
            }
            else
            {
                command = new SqlCommand("INSERT INTO Login (Username, PassWord, CanBo,chidoan)" +
                    "VALUES (@username, @password,@canbo,@chidoan)", mydb.getConnection);
                command.Parameters.Add("@username", SqlDbType.Char).Value = username;
                command.Parameters.Add("@password", SqlDbType.Char).Value = password;
                command.Parameters.Add("@canbo", SqlDbType.Char).Value = canbo;
                command.Parameters.Add("@chidoan", SqlDbType.Char).Value = chidoan;
            }

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.CloseConnection();
                return true;
            }
            else
            {
                mydb.CloseConnection();
                return false;
            }
        }
        //Chỉnh sữa
        public bool Doimatkhau(string username, string passwordcu, string passwordmoi)
        {
            SqlCommand command = new SqlCommand("UPDATE Login SET PassWord = @pass_moi " +
                "Where Username=@username And Password=@pass_cu", mydb.getConnection);
            command.Parameters.Add("@username", SqlDbType.Char).Value = username;
            command.Parameters.Add("@pass_cu", SqlDbType.Char).Value = passwordcu;
            command.Parameters.Add("@pass_moi", SqlDbType.Char).Value = passwordmoi;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.CloseConnection();
                return true;
            }
            else
            {
                mydb.CloseConnection();
                return false;
            }
        }
        //
        public bool xoaTaikhoan(string password)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Login WHERE PassWord = @password", mydb.getConnection);
            command.Parameters.Add("@password", SqlDbType.Char).Value = password;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.CloseConnection();
                return true;
            }
            else
            {
                mydb.CloseConnection();
                return false;
            }
        }
        //
        public DataTable getTaikhoan(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
