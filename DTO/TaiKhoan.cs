using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private string pass;

        public string Pass 
        {
            get { return pass; }
            set { pass = value; }
        }

        private int maNV;

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        
        public TaiKhoan()
        {
            this.User = "";
            this.Pass = "";
            this.MaNV = 0;
        }

        public TaiKhoan(string User, string Pass, int MaNV)
        {
            this.User = User;
            this.Pass = Pass;
            this.MaNV = MaNV;
        }
    }
}
