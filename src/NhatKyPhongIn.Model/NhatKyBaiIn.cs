using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhatKyPhongIn.Model
{
    public class NhatKyBaiIn
    {
        public string TenNhatKy { get; set; }
        public ThoIn NguoiIn { get; set; }
        public MayIn ChoMayIn { get; set; }
        public List<BaiIn> GomBaiIn = new List<BaiIn>();
        public int TongSoClickChay { get; set; }
        public string DonViTinhClick { get; set; }

        public double GomSoClickThu { get; set; }
        public double GomSoClickHu { get; set; }
        public DateTime ThoiGianLapPhieu { get; set; }//lấy từ hệ thống
        public DateTime ThoiGianInXong { get; set; }
    }
}
