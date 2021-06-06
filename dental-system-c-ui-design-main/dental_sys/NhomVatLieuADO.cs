using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class NhomVatLieuADO
    {
        int id;
        string tenNhom;

        public int Id { get => id; set => id = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }

        public NhomVatLieuADO(int id, string tenNhom)
        {
            this.id = id;
            this.tenNhom = tenNhom;
        }
    }
}
