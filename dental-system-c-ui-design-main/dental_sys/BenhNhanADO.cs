using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class BenhNhanADO
    {
        private string tenBenhNhan;
        private int id;

        public string TenBenhNhan { get => tenBenhNhan; set => tenBenhNhan = value; }
        public int Id { get => id; set => id = value; }

        public BenhNhanADO() { }
        public BenhNhanADO(string tenBenhNhan, int id)
        {
            TenBenhNhan = tenBenhNhan;
            Id = id;
        }
    }
}