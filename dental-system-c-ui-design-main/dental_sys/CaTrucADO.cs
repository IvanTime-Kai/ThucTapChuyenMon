using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class CaTrucADO
    {
        private int id;
        private string tenBacSi;
        private DateTime ngayTruc;
        private string ca;
        private string trangThai;

        public int Id { get => id; set => id = value; }
        public string TenBacSi { get => tenBacSi; set => tenBacSi = value; }
        public DateTime NgayTruc { get => ngayTruc; set => ngayTruc = value; }
        public string Ca { get => ca; set => ca = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public CaTrucADO() { }

        public CaTrucADO(int id, string tenBacSi, DateTime ngayTruc, string ca, string trangThai)
        {
            this.id = id;
            this.tenBacSi = tenBacSi;
            this.ngayTruc = ngayTruc;
            this.ca = ca;
            this.trangThai = trangThai;
        }
    }
}
