//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dental_sys
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chi
    {
        public int id { get; set; }
        public Nullable<int> NguoiChi { get; set; }
        public Nullable<int> KhoanChi { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.DateTime> NgayChi { get; set; }
    
        public virtual Khoanchi Khoanchi1 { get; set; }
        public virtual User User { get; set; }
    }
}
