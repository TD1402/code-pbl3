//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3
{
    using System;
    using System.Collections.Generic;
    
    public partial class MuonSach
    {
        public Nullable<int> STT { get; set; }
        public string Mã_mượn { get; set; }
        public string Mã_Người_Mượn { get; set; }
        public string Tên_Người_Mượn { get; set; }
        public string Mã_Sách { get; set; }
        public string Tình_Trạng { get; set; }
        public Nullable<System.DateTime> Thời_Gian_Mượn { get; set; }
        public Nullable<System.DateTime> Thời_Gian_Trả { get; set; }
        public string Mã_Nhân_Viên { get; set; }
    
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
