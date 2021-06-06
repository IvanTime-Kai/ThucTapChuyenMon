using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class NhapVatLieuADO
    {
        int id;
        string tenVatLieu;
        int soLuong;
        int tongTien;
        DateTime ngayNhap;

        public int Id { get => id; set => id = value; }
        public string TenVatLieu { get => tenVatLieu; set => tenVatLieu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }

        public NhapVatLieuADO(int id, string tenVatLieu, int soLuong, int tongTien, DateTime ngayNhap)
        {
            this.id = id;
            this.tenVatLieu = tenVatLieu;
            this.soLuong = soLuong;
            this.tongTien = tongTien;
            this.ngayNhap = ngayNhap;
        }
    }
}
