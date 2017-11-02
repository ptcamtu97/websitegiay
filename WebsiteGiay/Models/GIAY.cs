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
    
    public partial class GIAY
    {
        public GIAY()
        {
            this.HINHSPs = new HashSet<HINHSP>();
            this.SIZEs = new HashSet<SIZE>();
        }
    
        public int MaGiay { get; set; }
        public string MaLoai { get; set; }
        public string TenGiay { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public string MoTa { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
    
        public virtual ICollection<HINHSP> HINHSPs { get; set; }
        public virtual LOAIGIAY LOAIGIAY { get; set; }
        public virtual ICollection<SIZE> SIZEs { get; set; }
    }
}
