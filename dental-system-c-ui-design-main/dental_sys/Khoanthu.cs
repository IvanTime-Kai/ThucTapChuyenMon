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
    
    public partial class Khoanthu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khoanthu()
        {
            this.Thus = new HashSet<Thu>();
        }
    
        public int id { get; set; }
        public string TenKhoanThu { get; set; }
        public Nullable<int> SoTien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thu> Thus { get; set; }
    }
}
