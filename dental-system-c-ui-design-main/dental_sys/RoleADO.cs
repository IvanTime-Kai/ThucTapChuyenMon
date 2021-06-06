using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class RoleADO
    {
        int id;
        string roleName;
        int mucLuong;

        public int Id { get => id; set => id = value; }
        public string RoleName { get => roleName; set => roleName = value; }
        public int MucLuong { get => mucLuong; set => mucLuong = value; }

        public RoleADO(int id, string roleName, int mucLuong)
        {
            this.id = id;
            this.roleName = roleName;
            this.mucLuong = mucLuong;
        }
    }
}
