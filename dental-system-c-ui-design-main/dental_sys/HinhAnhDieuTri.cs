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
    
    public partial class HinhAnhDieuTri
    {
        public int id { get; set; }
        public byte[] Hinh { get; set; }
        public Nullable<int> BDT_id { get; set; }
    
        public virtual BuoiDieuTri BuoiDieuTri { get; set; }
    }
}