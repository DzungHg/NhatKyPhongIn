using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhatKyPhongIn.Model
{
    public class NhatKyNgay
    {
        public DateTime Ngay { get; set; }
        public string TenNhatKyNgay { get; set; }
        public List<NhatKyBaiIn> GomNhatKyBaiIn = new List<NhatKyBaiIn>();
        public DateTime ThoiGianTao { get; set; }
        public bool DaKetThuc { get; set; }
    }
}
