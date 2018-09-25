using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhatKyPhongIn.BDO;
using NhatKyPhongIn.Logic;
using NhatKyPhongIn.WFUI.Model;
using NhatKyPhongIn.WFUI.MapProfile;
using AutoMapper;

namespace NhatKyPhongIn.WFUI.DTOContext
{
    public class BaiSanPham
    {
        BaiSanPhamLogic logic = new BaiSanPhamLogic();
       
        
        public List<BaiSanPhamModel> DocTatCa()
        {           
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BaiSanPhamBDO, BaiSanPhamModel>());
            var mapper = config.CreateMapper();
            List<BaiSanPhamModel>  nguon = mapper.Map<List<BaiSanPhamBDO>, List<BaiSanPhamModel>>(logic.DocTatCa());
            return nguon;
        }

        public BaiSanPhamModel DocTheoId(int idBaiSanPham)
        {
            var objBDO = logic.DocTheoId(idBaiSanPham);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BaiSanPhamBDO, BaiSanPhamModel>());
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<BaiSanPhamModel>(objBDO);
            
            //Trả về
            return objModel;
        }

        public void Sua(BaiSanPhamModel baiSP)
        {            

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BaiSanPhamModel, BaiSanPhamBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<BaiSanPhamBDO>(baiSP);
            logic.Sua(objBDO);
        }

        public void Them(BaiSanPhamModel baiSP)
        {
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BaiSanPhamModel, BaiSanPhamBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map <BaiSanPhamBDO>(baiSP);
            //Chuyển
            //ChuyenObjectDTOThanhObjectBDO(baiSP, objBDO);
            //Thêm
            if (objBDO != null)
            {
                logic.Them(objBDO); //Thành công Mapper được
            }
        }

        public void Xoa(int idBaiSanPham)
        {
            logic.Xoa(idBaiSanPham);
        }
        ///
        /// 
        ///
        public void ChuyenObjectDTOThanhObjectBDO(BaiSanPhamModel objDTO, BaiSanPhamBDO objBDO)
        {
            Mapper.Initialize(cfg => cfg.AddProfile<BaiSanPhamModelBaiSanPhamBDOProfile>());
            //Khác null 2 cái tạo liền           
            if (objBDO != null && objDTO != null)
            {
                
                objBDO = Mapper.Map<BaiSanPhamBDO>(objDTO);
                
            }

        }
        public void ChuyenObjectBDOThanhObjectDTO(BaiSanPhamBDO objBDO, BaiSanPhamModel objDTO)
        {
            Mapper.Initialize(cfg => cfg.AddProfile<BaiSanPhamBDOBaiSanPhamModelProfile>());
            //Khác null 2 cái tạo liền           
            if (objBDO != null && objDTO != null)
            {
                objDTO = Mapper.Map<BaiSanPhamModel>(objBDO);
            }

        }
       

    }
}
