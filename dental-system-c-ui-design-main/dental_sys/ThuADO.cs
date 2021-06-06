using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class ThuADO
    {
        int id;
        string tenNguoiDong;
        string tenKhoanThu;
        DateTime ngayDong;
        string ghiChu;

        public int Id { get => id; set => id = value; }
        public string TenNguoiDong { get => tenNguoiDong; set => tenNguoiDong = value; }
        public string TenKhoanThu { get => tenKhoanThu; set => tenKhoanThu = value; }
        public DateTime NgayDong { get => ngayDong; set => ngayDong = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public ThuADO(int id, string tenNguoiDong, string tenKhoanThu, DateTime ngayDong, string ghiChu)
        {
            this.id = id;
            this.tenNguoiDong = tenNguoiDong;
            this.tenKhoanThu = tenKhoanThu;
            this.ngayDong = ngayDong;
            this.ghiChu = ghiChu;
        }
    }
}
