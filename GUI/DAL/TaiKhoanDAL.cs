using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class TaiKhoanDAL
    {
        string sqlconn = @"Data Source=LAPTOP-O3QUUSD1\SQLEXPRESS;Initial Catalog=BAN_QUAN_AN_NHANH;User ID=sa;Password=123";
        public int Check_Login(string user, string pass)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TAIKHOAN where TENDN ='" + user + "' and MATKHAU ='" + pass + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return 0;
                conn.Close();
            }
            else
            {
                return 1;
                conn.Close();
            }
        }
    }
}
