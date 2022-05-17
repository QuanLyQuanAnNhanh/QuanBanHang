using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAn
    {
        private int maMonAn;

        public int MaMonAn
        {
            get { return maMonAn; }
            set { maMonAn = value; }
        }

        private string tenMonAn;

        public string TenMonAn
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }

        private string loai;

        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }

        private string donViTinh;

        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        private int soLuongTon;

        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }

        private int giaBan;

        public int GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        
        
    }
}
