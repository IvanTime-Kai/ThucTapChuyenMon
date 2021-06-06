using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class VatLieuADO
    {
        int id;
        string tenVatLieu;
        string donVi;
        int tongNhap;
        int tongXuat;
        int tonKho;
        int donGia;

        public int Id { get => id; set => id = value; }
        public string TenVatLieu { get => tenVatLieu; set => tenVatLieu = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int TongNhap { get => tongNhap; set => tongNhap = value; }
        public int TongXuat { get => tongXuat; set => tongXuat = value; }
        public int TonKho { get => tonKho; set => tonKho = value; }
        public int DonGia { get => donGia; set => donGia = value; }

        public VatLieuADO(int id, string tenVatLieu, string donVi, int tongNhap, int tongXuat, int tonKho, int donGia)
        {
            this.id = id;
            this.tenVatLieu = tenVatLieu;
            this.donVi = donVi;
            this.tongNhap = tongNhap;
            this.tongXuat = tongXuat;
            this.tonKho = tonKho;
            this.donGia = donGia;
        }
    }
}
