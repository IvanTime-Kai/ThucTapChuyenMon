using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class KhoanChiADO
    {
        int id;
        string tenKhoanChi;
        int soTien;

        public int Id { get => id; set => id = value; }
        public string TenKhoanChi { get => tenKhoanChi; set => tenKhoanChi = value; }
        public int SoTien { get => soTien; set => soTien = value; }

        public KhoanChiADO(int id, string tenKhoanChi, int soTien)
        {
            this.id = id;
            this.tenKhoanChi = tenKhoanChi;
            this.soTien = soTien;
        }
    }
}
