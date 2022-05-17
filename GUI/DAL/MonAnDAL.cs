using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class MonAnDAL
    {
        string sqlconn = @"Data Source=LAPTOP-O3QUUSD1\SQLEXPRESS;Initial Catalog=BAN_QUAN_AN_NHANH;User ID=sa;Password=123";
        int maMonAn;

        public DataTable loadMonAn()
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            string sqlloadMonAn = @"select * from MONAN";
            SqlDataAdapter da = new SqlDataAdapter(sqlloadMonAn, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void themMonAn(string tenMonAn, string loai, string donViTinh, int gia)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            int maMonAn = layMaMonAnGanNhat() + 1;
            string sqlThemMonAn = @"INSERT INTO MONAN
                                    VALUES(" + maMonAn + ", N'" + tenMonAn + "', N'" + loai + "', N'" + donViTinh + "', 0, " + gia + ")";
            execSQL(sqlThemMonAn);
        }

        public int layMaMonAnGanNhat()
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            string sqlloadMonAn = @"select COUNT(*) from MONAN";
            SqlDataAdapter da = new SqlDataAdapter(sqlloadMonAn, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                maMonAn = int.Parse(dt.Rows[0][0].ToString());
            }
            conn.Close();
            return maMonAn;
        }
        
        public void execSQL(string sql)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch 
            {
                return;
            }
            cmd.Dispose();
            cmd = null;
            conn.Close();
        }

        public void suaGiaBan(int giaBan, int maMonAn)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            string sqlUpdateGiaMonAn = @"update MONAN
                                         set GIA = " + giaBan + " where MAMONAN = " + maMonAn + "";
            execSQL(sqlUpdateGiaMonAn);
            conn.Close();
        }

        public DataTable loadDSTenMonAn()
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            string sqlloadMonAn = @"select TENMONAN from MONAN";
            SqlDataAdapter da = new SqlDataAdapter(sqlloadMonAn, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
