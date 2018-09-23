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
    public class BaiSanPhamModelBaiSanPhamBDOProfile: Profile
    {
        public BaiSanPhamModelBaiSanPhamBDOProfile()
        {
            //Source, Destination
            this.CreateMap<BaiSanPhamModel, BaiSanPhamBDO>();
            
        }
    }
}
