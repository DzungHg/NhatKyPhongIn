using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhatKyPhongIn.WFUI.Model;

namespace NhatKyPhongIn.WFUI.DTOContext
{
    public interface IBaiSanPham
    {
        List<BaiSanPhamModel> DocTatCa();
        BaiSanPhamModel DocTheoId(int idBaiSanPham);

        void Them(BaiSanPhamModel baiSP);
        void Sua(BaiSanPhamModel baiSP);
        void Xoa(int idBaiSanPham);


    }
}
