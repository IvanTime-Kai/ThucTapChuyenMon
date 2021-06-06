using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class XuatVatLieuADO
    {
        int id;
        string tenVatLieu;
        int soLuong;
        DateTime ngayXuat;

        public int Id { get => id; set => id = value; }
        public string TenVatLieu { get => tenVatLieu; set => tenVatLieu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public DateTime NgayXuat { get => ngayXuat; set => ngayXuat = value; }

        public XuatVatLieuADO(int id, string tenVatLieu, int soLuong, DateTime ngayXuat)
        {
            this.id = id;
            this.tenVatLieu = tenVatLieu;
            this.soLuong = soLuong;
            this.ngayXuat = ngayXuat;
        }
    }
}
