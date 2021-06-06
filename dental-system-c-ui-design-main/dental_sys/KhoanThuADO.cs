using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class KhoanThuADO
    {
        int id;
        string tenKhoanThu;
        int soTien;

        public int Id { get => id; set => id = value; }
        public string TenKhoanThu { get => tenKhoanThu; set => tenKhoanThu = value; }
        public int SoTien { get => soTien; set => soTien = value; }

        public KhoanThuADO(int id, string tenKhoanThu, int soTien)
        {
            this.id = id;
            this.tenKhoanThu = tenKhoanThu;
            this.soTien = soTien;
        }
    }
}
