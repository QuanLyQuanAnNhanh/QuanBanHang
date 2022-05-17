using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguyenLieuDAL
    {
        string sqlconn = @"Data Source=LAPTOP-O3QUUSD1\SQLEXPRESS;Initial Catalog=BAN_QUAN_AN_NHANH;User ID=sa;Password=123";
        int maMonAn;
        DataTable dtNguyenLieu = new DataTable();
        DataTable dtTenNguyenLieu = new DataTable();
        int SoLuongNguyenLieu;
        int maHoaDonNhapNL;
        int maNLNhap;
        int GiaNL;
        int soLuongNL;
        int maNLMoi;

        public DataTable loadNguyenLieu()
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            string sqlloadMonAn = @"select * from NGUYENLIEU";
            SqlDataAdapter da = new SqlDataAdapter(sqlloadMonAn, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void cheBienMonAn(int soLuong, string tenMonAn)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            string sqlThemMonAn = @"update MONAN
                                    set SLHIENCO = " + soLuong + " + 1 where TENMONAN = N'" + tenMonAn + "'";
            execSQL(sqlThemMonAn);
        }


        public DataTable getCongThucCanNau(string tenMonAn)
        {
            DataTable dt = new DataTable();
            dt = getMaNguyenLieu(getMaMonAn(tenMonAn));
            dtNguyenLieu = dt;
            return dtNguyenLieu;
        }

        public int getMaMonAn(string tenMonAn)
        {
            string sqlGetMaMonAn = @"select MAMONAN from MONAN where TENMONAN = N'"+ tenMonAn +"'";
            SqlDataAdapter da = new SqlDataAdapter(sqlGetMaMonAn, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                maMonAn = int.Parse(dt.Rows[0][0].ToString());
            }
            return maMonAn;
        }

        public DataTable getMaNguyenLieu(int maMonAn)
        {
            string sqlGetMaNguyenLieu = @"select MANGUYENLIEU from CONGTHUCCHEBIENMONAN where MAMONAN = "+ maMonAn +"";
            SqlDataAdapter da = new SqlDataAdapter(sqlGetMaNguyenLieu, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void nguyenLieuDaCheBien(string tenMonAn)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            DataTable dtdsTenNguyenLieu = new DataTable();
            if (dtdsTenNguyenLieu.Rows.Count != 0)
            {
                dtdsTenNguyenLieu.Clear();
            }
            dtdsTenNguyenLieu = getTenNguyenLieu(tenMonAn);
            int j = dtdsTenNguyenLieu.Rows.Count;
            int i = 0;
            while (j > 0)
            {
                string sqlUpdateSLNguyenLieu = @"update NGUYENLIEU
                                                 set SOLUONG = " + getSoLuongNguyenLieu(dtdsTenNguyenLieu.Rows[i][0].ToString()) + " - 1 where TENNGUYENLIEU = N'" + dtdsTenNguyenLieu.Rows[i][0].ToString() + "'";
                execSQL(sqlUpdateSLNguyenLieu);
                i++;
                j--;
            }
            conn.Close();
        }

        public int getSoLuongNguyenLieu(string tenMonAn)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            DataTable dttbSL = new DataTable();
            string sqlGetTenNguyenLieu = @"select SOLUONG from NGUYENLIEU WHERE TENNGUYENLIEU = N'Phô Mai'";
            SqlDataAdapter da = new SqlDataAdapter(sqlGetTenNguyenLieu, sqlconn);
            da.Fill(dttbSL);
            SoLuongNguyenLieu = int.Parse(dttbSL.Rows[0][0].ToString());           
            conn.Close();
            return SoLuongNguyenLieu;
        }

        public DataTable getTenNguyenLieu(string tenMonAn)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            DataTable dtMaNL = new DataTable();
            dtMaNL = getMaNguyenLieu(getMaMonAn(tenMonAn));
            int j = dtMaNL.Rows.Count;
            if(dtTenNguyenLieu.Rows.Count != 0)
            {
                dtTenNguyenLieu.Clear();
            }
            int i = 0;
            while (j > 0)
            {
                string sqlGetTenNguyenLieu = @"select TENNGUYENLIEU from NGUYENLIEU where MANGUYENLIEU = " + dtMaNL.Rows[i][0].ToString() + "";
                SqlDataAdapter da = new SqlDataAdapter(sqlGetTenNguyenLieu, sqlconn);
                da.Fill(dtTenNguyenLieu);
                i++;
                j--;
            }
            conn.Close();
            return dtTenNguyenLieu;
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

        public void themHoaDonNhapNL(string tenNL, int soLuong)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            int maHoaDonNhap = LayMaHoaDonNhapNguyenLieu() + 1;
            string date = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            
            string insertHoaDonNhap = @"insert into NHAPMONAN
                                        values("+ maHoaDonNhap +", 1, N'" + date + "', 0)";
            execSQL(insertHoaDonNhap);
            
            string insertChiTietNhapHang = @"insert into CHITIETNHAPMONAN
                                             values(" + maHoaDonNhap + ", " + getMaNguyenLieuTheoTen(tenNL) + ", " + soLuong + ")";
            execSQL(insertChiTietNhapHang);

            string updateTongTienNhap = @"update NHAPMONAN
                                          set THANHTIEN = " + soLuong + " * " + getGiaNguyenLieu(tenNL) + " where MADONNHAP = " + maHoaDonNhap + "";
            execSQL(updateTongTienNhap);

            string updateSoLuongNguyenLieu = @"update NGUYENLIEU
                                               set SOLUONG = " + getSoLuongCuaNguyenLieu(tenNL) + " + " + soLuong + " where TENNGUYENLIEU = N'" + tenNL + "'";
            execSQL(updateSoLuongNguyenLieu);

            conn.Close();
        }

        public int getSoLuongCuaNguyenLieu(string tenNL)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            DataTable dtSLNL = new DataTable();
            string sqlGetTenNguyenLieu = @"select SOLUONG from NGUYENLIEU where TENNGUYENLIEU = N'" + tenNL + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlGetTenNguyenLieu, sqlconn);
            da.Fill(dtSLNL);
            soLuongNL = int.Parse(dtSLNL.Rows[0][0].ToString());           
            conn.Close();
            return soLuongNL;

            
        }

        public int getGiaNguyenLieu(string tenNL)
        {
            string sqlGetMaNguyenLieu = @"select GIA from NguyenLieu where TENNGUYENLIEU = N'" + tenNL + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlGetMaNguyenLieu, sqlconn);
            DataTable dt = new DataTable();
            if(dt.Rows.Count>0)
            {
                GiaNL = int.Parse(dt.Rows[0][0].ToString());
            }
            return GiaNL;
        }

        public int getMaNguyenLieuTheoTen(string tenNL)
        {
            string sqlGetMaNguyenLieu = @"select MANGUYENLIEU from NGUYENLIEU where TENNGUYENLIEU = N'" + tenNL + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlGetMaNguyenLieu, sqlconn);
            DataTable dt = new DataTable();
            if(dt.Rows.Count>0)
            {
                maNLNhap = int.Parse(dt.Rows[0][0].ToString());
            }
            return maNLNhap;
        }

        public int LayMaHoaDonNhapNguyenLieu()
        {
            string sqlGetMaMonAn = @"select COUNT(*) from NHAPMONAN";
            SqlDataAdapter da = new SqlDataAdapter(sqlGetMaMonAn, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                maHoaDonNhapNL = int.Parse(dt.Rows[0][0].ToString());
            }
            return maHoaDonNhapNL;
        }


        public int layMaNguyenLieuMoi()
        {
            string sqlMaNL = @"select COUNT(*) from NGUYENLIEU";
            SqlDataAdapter da = new SqlDataAdapter(sqlMaNL, sqlconn);
            DataTable dtNLMOI = new DataTable();
            da.Fill(dtNLMOI);
            if (dtNLMOI.Rows.Count > 0)
            {
                maNLMoi = int.Parse(dtNLMOI.Rows[0][0].ToString());
            }
            return maNLMoi;
        }

        public void themNguyenLieuMoi(string tenMonAn, string tenNL, int sLuong, string DVT, int Gia)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            int maNguyenLieu = layMaNguyenLieuMoi() + 1;
            string insertNguyenLieu = @"INSERT INTO NGUYENLIEU VALUES(" + maNguyenLieu + ", N'" + tenNL + "', " + sLuong + ", N'" + DVT + "', " + Gia + ")";
            execSQL(insertNguyenLieu);

            string insertCongThucNauMonAn = @"INSERT INTO CONGTHUCCHEBIENMONAN
                                              VALUES(" + getMaMonAn(tenMonAn) + ", " + maNguyenLieu + " , 1, 1)";
            execSQL(insertCongThucNauMonAn);
            conn.Close();
        }

        int maNLThemMoi;
        public int layMaNguyenLieu()
        {
            string sqlSLTongNL = @"select COUNT(*) from NGUYENLIEU ";
            SqlDataAdapter da = new SqlDataAdapter(sqlSLTongNL, sqlconn);
            DataTable dt = new DataTable();
            if (dt.Rows.Count > 0)
            {
                maNLThemMoi = int.Parse(dt.Rows[0][0].ToString());
            }
            return maNLThemMoi;
        }

         public DataTable loadDSDVT()
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            string sqlloadDVT = @" select DONVITINH from NGUYENLIEU group by DONVITINH";
            SqlDataAdapter da = new SqlDataAdapter(sqlloadDVT, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
