using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhatKyPhongIn.BDO;

namespace NhatKyPhongIn.DAL.IReposNhatKyPhongIn
{
    public interface IBaiInDAO
    {

        IEnumerable<BaiInBDO> DocTatCa();

        BaiInBDO DocTheoId(int id);
        void Them(BaiInBDO entityBDO);
        void Sua(BaiInBDO entityBDO);
        void Xoa(int id);
    }
}
