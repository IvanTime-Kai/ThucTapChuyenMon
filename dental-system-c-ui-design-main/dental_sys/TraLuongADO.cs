using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class TraLuongADO
    {
        int id;
        string ten;
        string thangLuong; // datetime format
        string chucVu;
        DateTime? ngayTra;
        int soTienTra;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string ThangLuong { get => thangLuong; set => thangLuong = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public DateTime? NgayTra { get => ngayTra; set => ngayTra = value; }
        public int SoTienTra { get => soTienTra; set => soTienTra = value; }

        public TraLuongADO(int id, string ten, string thangLuong, string chucVu, DateTime? ngayTra, int soTienTra)
        {
            this.id = id;
            this.ten = ten;
            this.thangLuong = thangLuong;
            this.chucVu = chucVu;
            this.ngayTra = ngayTra;
            this.soTienTra = soTienTra;
        }

        public TraLuongADO(int id, string ten, string thangLuong, string chucVu, int soTienTra)
        {
            this.id = id;
            this.ten = ten;
            this.thangLuong = thangLuong;
            this.chucVu = chucVu;
            this.soTienTra = soTienTra;
        }
    }
}
