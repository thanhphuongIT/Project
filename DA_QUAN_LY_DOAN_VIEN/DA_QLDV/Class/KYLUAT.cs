using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DA_QLDV
{
    class KYLUAT
    {
        My_Database mydb = new My_Database();
        // Thêm
        public bool themKyluat(string makl, int madv, string CDoan, string loaivipham, string hinhthuc, string namhoc)
        {
            SqlCommand command = new SqlCommand("INSERT INTO KyLuat( MaKL,MaDV,CDoan,Loaivipham,Hinhthuc,Namhoc)" +
                "VALUES (@makl,@madv,@cdoan,@vipham,@hinhthuc,@namhoc)", mydb.getConnection);
            command.Parameters.Add("@makl", SqlDbType.Char).Value = makl;
            command.Parameters.Add("@madv", SqlDbType.Int).Value = madv;
            command.Parameters.Add("@cdoan", SqlDbType.Char).Value = CDoan;
            command.Parameters.Add("@vipham", SqlDbType.NVarChar).Value = loaivipham;
            command.Parameters.Add("@hinhthuc", SqlDbType.NVarChar).Value = hinhthuc;
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
        public bool suaKyluat(string makl, int madv, string CDoan, string loaivipham, string hinhthuc, string namhoc)
        {
            SqlCommand command = new SqlCommand("UPDATE KyLuat SET  MaDv=@madv,CDoan=@cdoan,Loaivipham=@vipham,Hinhthuc=@hinhthuc,Namhoc=@namhoc" +
                " WHERE MaKL=@makl", mydb.getConnection);
            command.Parameters.Add("@makl", SqlDbType.Char).Value = makl;
            command.Parameters.Add("@madv", SqlDbType.Int).Value = madv;
            command.Parameters.Add("@cdoan", SqlDbType.Char).Value = CDoan;
            command.Parameters.Add("@vipham", SqlDbType.NVarChar).Value = loaivipham;
            command.Parameters.Add("@hinhthuc", SqlDbType.NVarChar).Value = hinhthuc;
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
        public bool xoaKyLuat(string makl)
        {
            SqlCommand command = new SqlCommand("DELETE FROM KyLuat WHERE MaKL = @makl", mydb.getConnection);
            command.Parameters.Add("@makl", SqlDbType.Char).Value = makl;
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
        public DataTable getKyluat(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
