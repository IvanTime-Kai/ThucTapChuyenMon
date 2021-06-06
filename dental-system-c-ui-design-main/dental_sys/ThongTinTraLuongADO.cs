using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    class ThongTinTraLuongADO
    {
        int id;
        DateTime ngayVaoLam;
        int mucLuong;
        string roleName;

        public int Id { get => id; set => id = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public int MucLuong { get => mucLuong; set => mucLuong = value; }
        public string RoleName { get => roleName; set => roleName = value; }

        public ThongTinTraLuongADO(int id, DateTime ngayVaoLam, int mucLuong, string roleName)
        {
            this.id = id;
            this.ngayVaoLam = ngayVaoLam;
            this.mucLuong = mucLuong;
            this.roleName = roleName;
        }
    }
}
