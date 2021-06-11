using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class ThanhToanADO_BDT
    {
        int id;
        DateTime ngayKham;
        int chiPhi;
        string chuanDoan;
        string ghiChu;
        string trangThai; // Đã thanh toán hoặc chưa

        public int Id { get => id; set => id = value; }
        public DateTime NgayKham { get => ngayKham; set => ngayKham = value; }
        public int ChiPhi { get => chiPhi; set => chiPhi = value; }
        public string ChuanDoan { get => chuanDoan; set => chuanDoan = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public ThanhToanADO_BDT(int id, DateTime ngayKham, int chiPhi, string chuanDoan, string ghiChu, string trangThai)
        {
            this.id = id;
            this.ngayKham = ngayKham;
            this.chiPhi = chiPhi;
            this.chuanDoan = chuanDoan;
            this.ghiChu = ghiChu;
            this.trangThai = trangThai;
        }
    }
}
