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
    
    public partial class GIATOUR
    {
        public string MaGia { get; set; }
        public string MaTour { get; set; }
        public Nullable<int> ThanhTien { get; set; }
        public Nullable<System.DateTime> ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
    
        public virtual TOURDULICH TOURDULICH { get; set; }
    }
}
