using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NhatKyPhongIn.BDO;
using NhatKyPhongIn.WFUI.Model;

namespace NhatKyPhongIn.WFUI.MapProfile
{
    public class BaiSanPhamBDOBaiSanPhamModelProfile: Profile
    {
        public BaiSanPhamBDOBaiSanPhamModelProfile()
        {
            //Source, Destination
            this.CreateMap<BaiSanPhamBDO, BaiSanPhamModel>();
            
        }

    }
}
