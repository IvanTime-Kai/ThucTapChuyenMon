using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class ThanhToanADO_DT
    {
        int id;
        DateTime ngayKham;
        string tenNguoiKeDon;
        int thanhTien;
        string trangThai; // Đã thanh toán hoặc chưa

        public int Id { get => id; set => id = value; }
        public DateTime NgayKham { get => ngayKham; set => ngayKham = value; }
        public string TenNguoiKeDon { get => tenNguoiKeDon; set => tenNguoiKeDon = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public ThanhToanADO_DT(int id, DateTime ngayKham, string tenNguoiKeDon, int thanhTien, string trangThai)
        {
            this.id = id;
            this.ngayKham = ngayKham;
            this.tenNguoiKeDon = tenNguoiKeDon;
            this.thanhTien = thanhTien;
            this.trangThai = trangThai;
        }
    }
}
