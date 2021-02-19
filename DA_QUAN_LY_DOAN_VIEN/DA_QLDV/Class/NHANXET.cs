using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DA_QLDV
{
    class NHANXET
    {
        My_Database mydb = new My_Database();
        // Thêm
        public bool themNhanxet(string manx, int madv, string CDoan, string uudiem, string khuyetdiem,string xeploai, string namhoc)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NhanXet (MaNX, MaDV, CDoan, Uudiem, Khuyetdiem, Xeploai, Namhoc)" +
                "VALUES (@manx,@madv, @cdoan,@uudiem, @khuyetdiem, @xeploai, @namhoc)", mydb.getConnection);
            command.Parameters.Add("@manx", SqlDbType.Char).Value = manx;
            command.Parameters.Add("@madv", SqlDbType.Int).Value = madv;
            command.Parameters.Add("@cdoan", SqlDbType.Char).Value = CDoan;
            command.Parameters.Add("@uudiem", SqlDbType.NText).Value = uudiem;
            command.Parameters.Add("@khuyetdiem", SqlDbType.NText).Value = khuyetdiem;
            command.Parameters.Add("@xeploai", SqlDbType.NVarChar).Value = xeploai;
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
        public bool suaNhanxet(string manx, int madv, string CDoan, string uudiem, string khuyetdiem, string xeploai, string namhoc)
        {
            SqlCommand command = new SqlCommand("UPDATE NhanXet SET MaDV=@madv, CDoan=@cdoan, Uudiem=@uudiem, Khuyetdiem=@khuyetdiem, Xeploai=@xeploai,Namhoc=@namhoc" +
                " WHERE MaNX=@manx", mydb.getConnection);
            command.Parameters.Add("@manx", SqlDbType.Char).Value = manx;
            command.Parameters.Add("@madv", SqlDbType.Int).Value = madv;
            command.Parameters.Add("@cdoan", SqlDbType.Char).Value = CDoan;
            command.Parameters.Add("@uudiem", SqlDbType.NText).Value = uudiem;
            command.Parameters.Add("@khuyetdiem", SqlDbType.NText).Value = khuyetdiem;
            command.Parameters.Add("@xeploai", SqlDbType.NVarChar).Value = xeploai;
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
        public bool xoaNhanxet(string manx)
        {
            SqlCommand command = new SqlCommand("DELETE FROM NhanXet WHERE MaNX = @manx", mydb.getConnection);
            command.Parameters.Add("@manx", SqlDbType.Char).Value = manx;
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
        public DataTable getNhanxet(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.CloseConnection();
            return count;
        }
        public string totalNhanxetchidoan()
        {
            return execCount("SELECT COUNT(*) FROM NhanXet Where CDoan = '" + Global.GlobalLop + "'");
        }
        public string totalChuatotchidoan()
        {
            return execCount("SELECT COUNT(*) FROM NhanXet Where CDoan = '" + Global.GlobalLop + "' and Xeploai = N'Chưa Tốt'");
        }
        public string totalTotchidoan()
        {
            return execCount("SELECT COUNT(*) FROM NhanXet Where CDoan = '" + Global.GlobalLop + "' and Xeploai = N'Tốt'");
        }

        public string totalNhanxet()
        {
            return execCount("SELECT COUNT(*) FROM NhanXet");
        }
        public string totalChuatot()
        {
            return execCount("SELECT COUNT(*) FROM NhanXet Where Xeploai = N'Chưa Tốt'");
        }
        public string totalTot()
        {
            return execCount("SELECT COUNT(*) FROM NhanXet Where Xeploai = N'Tốt'");
        }
    }
}
