//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyTour
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHANBONHANVIEN_DOAN
    {
        public string MaNhanVien { get; set; }
        public string MaDoan { get; set; }
        public string NhiemVu { get; set; }
    
        public virtual DOANDULICH DOANDULICH { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
