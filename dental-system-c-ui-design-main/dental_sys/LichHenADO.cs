using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class LichHenADO
    {
        private int id;
        private string tenBacSi;
        private string tenBenhNhan;
        private DateTime ngayHen;
        private string ca;
        private string noiDung;
        private string trangThai;

        public string TenBacSi { get => tenBacSi; set => tenBacSi = value; }
        public string TenBenhNhan { get => tenBenhNhan; set => tenBenhNhan = value; }
        public DateTime NgayHen { get => ngayHen; set => ngayHen = value; }
        public string Ca { get => ca; set => ca = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int Id { get => id; set => id = value; }

        public LichHenADO()
        {
        }

        public LichHenADO(int id, string tenBacSi, string tenBenhNhan, DateTime ngayHen, string ca, string noiDung, string trangThai)
        {
            this.id = id;
            this.tenBacSi = tenBacSi;
            this.tenBenhNhan = tenBenhNhan;
            this.ngayHen = ngayHen;
            this.ca = ca;
            this.noiDung = noiDung;
            this.trangThai = trangThai;
        }
    }
}

