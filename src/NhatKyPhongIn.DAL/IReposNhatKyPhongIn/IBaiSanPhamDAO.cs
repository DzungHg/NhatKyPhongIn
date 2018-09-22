using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhatKyPhongIn.BDO;

namespace NhatKyPhongIn.DAL.IReposNhatKyPhongIn
{
    public interface IBaiSanPhamDAO
    {

        IEnumerable<BaiSanPhamBDO> LayTatCa();


        BaiSanPhamBDO LayTheoId(int iD);
        void Them(BaiSanPhamBDO entityBDO);
        void Sua(BaiSanPhamBDO entityBDO);
        void Xoa(int iD);
    }
}
