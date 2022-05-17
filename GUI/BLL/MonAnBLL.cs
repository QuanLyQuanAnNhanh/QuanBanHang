using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class MonAnBLL
    {
        MonAnDAL monAnDAL = new MonAnDAL();
        public DataTable LayMonAnBLL()
        {
            return monAnDAL.loadMonAn();
        }

        public void themMonAnBLL(string tenMonAn, string loai, string donViTinh, int gia)
        {
            monAnDAL.themMonAn(tenMonAn, loai, donViTinh, gia);
        }

        public void SuaGiaBanBLL(int gia, int maMonAn)
        {
            monAnDAL.suaGiaBan(gia, maMonAn);
        }

        public DataTable loadDSTenMonAnBLL()
        {
            return monAnDAL.loadDSTenMonAn();
        }
    }
}
