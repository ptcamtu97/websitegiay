//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteGiay.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        public HOADON()
        {
            this.CTHOADONs = new HashSet<CTHOADON>();
        }
    
        public int MaHD { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<bool> Duyet { get; set; }
    
        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
