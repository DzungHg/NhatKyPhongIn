using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhatKyPhongIn.Common.Enums;

namespace NhatKyPhongIn.Model
{
    public class BaiIn
    {
        public string SoDonHang { get; set; }
        public string TenBaiIn { get; set; }
        public string NguoiLamFile { get; set; }
        public string DienGiaiIn { get; set; }
        public MayIn MayInYeuCau { get; set; }
        public double ToChayRong { get; set; }
        public double ToChayDai { get; set; }
        public int SoLuongToChayCanIn { get; set; }
        public int SoLuongToChayBuHao { get; set; }
        public int SoMatIn { get; set; }
        public MauIn MauIn { get; set; }
        public MucUuTien MucUuTien { get; set; }
        public string DuongDanFile { get; set; }
        public TinhTrangBaiIn TinhTrangBaiIn { get; set; }

    }
}
