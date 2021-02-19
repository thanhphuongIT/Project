using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DA_QLDV
{
    class DOANVIEN
    {
        My_Database mydb = new My_Database();
        public bool themDoanVien(int mssv, string hoten,string gioitinh,DateTime ngaysinh, DateTime ngayvaodoan, string chucvu, int cmnd, 
            string hocvan, string tongiao, string dantoc, string cdoan, string diachi, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Sinhvien( MSSV, Hoten,Gioitinh,Ngaysinh, Ngayvaodoan, Chucvu, CMND, Hocvan, Tongiao, Dantoc, CDoan, Diachi, Picture)" +
                "VALUES (@mssv,@hoten,@gtinh,@ngaysinh,@ngayvaodoan,@chucvu,@cmnd,@hocvan,@tongiao,@dantoc,@cdoan,@diachi,@picture)", mydb.getConnection);
            command.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;
            command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
            command.Parameters.Add("@gtinh", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@ngayvaodoan", SqlDbType.DateTime).Value = ngayvaodoan;
            command.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = chucvu;
            command.Parameters.Add("@cmnd", SqlDbType.Int).Value = cmnd;
            command.Parameters.Add("@hocvan", SqlDbType.Char).Value = hocvan;
            command.Parameters.Add("@tongiao", SqlDbType.NVarChar).Value = tongiao;
            command.Parameters.Add("@dantoc", SqlDbType.NVarChar).Value = dantoc;
            command.Parameters.Add("@cdoan", SqlDbType.Char).Value = cdoan;
            command.Parameters.Add("@diachi", SqlDbType.NText).Value = diachi;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

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
        public bool suaDoanVien(int MSSV, string Hoten,string gioitinh, DateTime Ngaysinh, DateTime Ngayvaodoan, string Chucvu,
            int CMND, string Hocvan,string Tongiao ,string Dantoc,string CDoan,string Diachi ,MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE Sinhvien SET MSSV=@ms, Hoten=@hten,Gioitinh=@gtinh ,Ngaysinh=@nsinh, Ngayvaodoan=@nvdoan," +
                "Chucvu=@cvu,CMND=@cminh,Hocvan=@hvan,Tongiao=@tgiao,Dantoc=@dtoc,CDoan=@cdoan,Diachi=@dchi ,picture=@pic WHERE MSSV=@ms", mydb.getConnection);
            command.Parameters.Add("@ms", SqlDbType.Int).Value = MSSV;
            command.Parameters.Add("@hten", SqlDbType.NVarChar).Value = Hoten;
            command.Parameters.Add("@gtinh", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@nsinh", SqlDbType.DateTime).Value = Ngaysinh;
            command.Parameters.Add("@nvdoan", SqlDbType.DateTime).Value = Ngayvaodoan;
            command.Parameters.Add("@cvu", SqlDbType.NVarChar).Value = Chucvu;
            command.Parameters.Add("@cminh", SqlDbType.Int).Value = CMND;
            command.Parameters.Add("@hvan", SqlDbType.Char).Value = Hocvan;
            command.Parameters.Add("@tgiao", SqlDbType.NVarChar).Value = Tongiao;
            command.Parameters.Add("@dtoc", SqlDbType.NVarChar).Value = Dantoc;
            command.Parameters.Add("@cdoan", SqlDbType.Char).Value = CDoan;
            command.Parameters.Add("@dchi", SqlDbType.NText).Value = Diachi;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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
        public bool xoaDoanVien(int mssv)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Sinhvien WHERE MSSV = @mssv", mydb.getConnection);
            command.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;
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
        public DataTable getDoanvien(SqlCommand command)
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
        public string totalDoanvienchidoan()
        {
            return execCount("SELECT COUNT(*) FROM Sinhvien Where CDoan = '" + Global.GlobalLop + "'");
        }
        public string totalNamchidoan()
        {
            return execCount("SELECT COUNT(*) FROM Sinhvien Where CDoan = '" + Global.GlobalLop + "' and Gioitinh = N'Nam'");
        }
        public string totalNuchidoan()
        {
            return execCount("SELECT COUNT(*) FROM Sinhvien Where CDoan = '" + Global.GlobalLop + "' and Gioitinh = N'Nữ'");
        }

        public string totalDoanvien()
        {
            return execCount("SELECT COUNT(*) FROM Sinhvien");
        }
        public string totalNam()
        {
            return execCount("SELECT COUNT(*) FROM Sinhvien Where Gioitinh = N'Nam'");
        }
        public string totalNu()
        {
            return execCount("SELECT COUNT(*) FROM Sinhvien Where Gioitinh = N'Nữ'");
        }
    }
}
