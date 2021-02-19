using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DA_QLDV
{
    class CHIDOAN
    {
        My_Database mydb = new My_Database();
        // Thêm
        public bool themChidoan(string macd, int slsv, int mabithu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Chidoan (MaCD, SLSV, Mabithu)" +
                "VALUES (@macd, @slsv,@mabithu)", mydb.getConnection);
            command.Parameters.Add("@macd", SqlDbType.Char).Value = macd;
            command.Parameters.Add("@slsv", SqlDbType.Int).Value = slsv;
            command.Parameters.Add("@mabithu", SqlDbType.Int).Value = mabithu;

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
        public bool suaChidoan(string macd, int slsv, int mabithu)
        {
            SqlCommand command = new SqlCommand("UPDATE Chidoan SET SLSV=@slsv, Mabithu=@mabithu" +
                " WHERE MaCD = @macd", mydb.getConnection);
            command.Parameters.Add("@macd", SqlDbType.Char).Value = macd;
            command.Parameters.Add("@slsv", SqlDbType.Int).Value = slsv;
            command.Parameters.Add("@mabithu", SqlDbType.Int).Value = mabithu;

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
        public bool xoaChidoan(string macd)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Chidoan WHERE MaCD = @macd", mydb.getConnection);
            command.Parameters.Add("@macd", SqlDbType.Char).Value = macd;
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
        public DataTable getChidoan(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
