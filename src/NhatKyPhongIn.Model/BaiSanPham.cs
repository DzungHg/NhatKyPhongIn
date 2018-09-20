using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhatKyPhongIn.Common.Enums;

namespace NhatKyPhongIn.Model
{
    public class BaiSanPham
    {
        public string SoDonHang { get; set; }
        public string TenSanPham { get; set; }
        public string YeuCau { get; set; }
        public string DuongDanFile01 { get; set; }
        public string DuongDanFile02 { get; set; }
        public string DuongDanFile03 { get; set; }
        public TinhTrangBaiSanPham TinhTrangBaiSanPham { get; set; }
        

    }
}
