//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnLTW.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonHang
    {
        public DonHang()
        {
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }
    
        public int MaDonHang { get; set; }
        public Nullable<System.DateTime> NgayGiao { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public Nullable<int> DaThanhToan { get; set; }
        public Nullable<int> TinhTrangGiaoHang { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<int> MaNV { get; set; }
    
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
