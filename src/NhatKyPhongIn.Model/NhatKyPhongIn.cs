using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhatKyPhongIn.Model
{
    public class NhatKyPhongIn
    {
        public List<NhatKyNgay> GomNhatKyNgay { get; set; } = new List<NhatKyNgay>();
        public string TenNhatKy { get; set; }

        public DateTime  TuNgay { get; set; }
        public DateTime DeNgay { get; set; }
        public bool DaKetThuc { get; set; }
    }
}
