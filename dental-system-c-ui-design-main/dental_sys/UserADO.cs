using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class UserADO
    {
        int id;
        string ten;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }

        public UserADO(int id, string ten)
        {
            this.id = id;
            this.ten = ten;
        }
    }
}
