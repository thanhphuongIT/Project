using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DA_QLDV
{
    class DOANPHI
    {
        My_Database mydb = new My_Database();
        // Thêm
        public bool themDoanphi(string madp, int madv, int sotien, string tinhtrang, string namhoc)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Doanphi( MaDP,MaDV,Sotien,Tinhtrang,Namhoc)" +
                "VALUES (@madp,@madv,@sotien,@tinhtrang,@namhoc)", mydb.getConnection);
            command.Parameters.Add("@madp", SqlDbType.Char).Value = madp;
            command.Parameters.Add("@madv", SqlDbType.Int).Value = madv;
            command.Parameters.Add("@sotien", SqlDbType.Int).Value = sotien;
            command.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = tinhtrang;
            command.Parameters.Add("@namhoc", SqlDbType.Char).Value = namhoc;

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
        public bool suaDoanphi(string madp, int madv, int sotien, string tinhtrang, string namhoc)
        {
            SqlCommand command = new SqlCommand("UPDATE Doanphi SET  MaDV=@madv,Sotien =@sotien, Tinhtrang =@tinhtrang,Namhoc=@namhoc" +
                " WHERE MaDP=@madp", mydb.getConnection);
            command.Parameters.Add("@madp", SqlDbType.Char).Value = madp;
            command.Parameters.Add("@madv", SqlDbType.Int).Value = madv;
            command.Parameters.Add("@sotien", SqlDbType.Int).Value = sotien;
            command.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = tinhtrang;
            command.Parameters.Add("@namhoc", SqlDbType.Char).Value = namhoc;

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
        public bool xoaDoanphi(string madp)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Doanphi WHERE MaDP = @madp", mydb.getConnection);
            command.Parameters.Add("@madp", SqlDbType.Char).Value = madp;
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
        public DataTable getDoanphi(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
