using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class BacSiADO
    {
        private string tenBacSi;
        private int id;

        public string TenBacSi { get => tenBacSi; set => tenBacSi = value; }
        public int Id { get => id; set => id = value; }

        public BacSiADO() { }

        public BacSiADO(string tenBacSi, int id)
        {
            this.tenBacSi = tenBacSi;
            this.id = id;
        }
    }
}
