using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class ChiADO
    {
        int id;
        string tenNguoiChi;
        string tenKhoanChi;
        DateTime ngayChi;
        string ghiChu;

        public int Id { get => id; set => id = value; }
        public string TenNguoiChi { get => tenNguoiChi; set => tenNguoiChi = value; }
        public string TenKhoanChi { get => tenKhoanChi; set => tenKhoanChi = value; }
        public DateTime NgayChi { get => ngayChi; set => ngayChi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public ChiADO(int id, string tenNguoiChi, string tenKhoanChi, DateTime ngayChi, string ghiChu)
        {
            this.id = id;
            this.tenNguoiChi = tenNguoiChi;
            this.tenKhoanChi = tenKhoanChi;
            this.ngayChi = ngayChi;
            this.ghiChu = ghiChu;
        }
    }
}
