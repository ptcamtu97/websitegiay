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
    
    public partial class NHANVIEN
    {
        public NHANVIEN()
        {
            this.BAIVIETs = new HashSet<BAIVIET>();
        }
    
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string TenDN { get; set; }
        public string MatKhau { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public Nullable<int> Quyen { get; set; }
    
        public virtual ICollection<BAIVIET> BAIVIETs { get; set; }
    }
}
