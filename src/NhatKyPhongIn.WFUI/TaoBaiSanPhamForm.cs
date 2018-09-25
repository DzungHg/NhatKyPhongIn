using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NhatKyPhongIn.Common.Enums;
using NhatKyPhongIn.WFUI.Model;
using NhatKyPhongIn.WFUI.DTOContext;

namespace NhatKyPhongIn.WFUI
{
    public partial class TaoBaiSanPhamForm : Telerik.WinControls.UI.RadForm
    {
        //Thêm field
        /// <summary>
        /// Dùng nhận Id khi sửa hoặc xóa form
        /// </summary>
        //public int IdModel { get; set; }
        /// <summary>
        /// Theo dõi tình trạng form thêm sửa xóa
        /// </summary>
        public TinhTrangForm TinhTrangForm { get; set; }
        //Dùng biến để sửa
        public BaiSanPhamModel baiSanPhamEdited;
        public TaoBaiSanPhamForm()
        {
            InitializeComponent();

            InitializeFormData();
            //Đặt Cb
            tinhTrangBaiSPDropDownList.SelectedIndex = 0;//Đầu tiên "Nhap"
            
        }
        private void InitializeFormData()
        {
            //Bind the account level settings
            foreach (TinhTrangBaiSanPham tinhTrang in Enum.GetValues(typeof(TinhTrangBaiSanPham)))
            {
                tinhTrangBaiSPDropDownList.Items.Add(tinhTrang.ToString());
            }
        }
        
        private bool ValidateForm()
        {
            bool output = true;

            if (soDonHangRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }

            if (tenBaiInRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (yeuCauRTextBoxCtrl.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (tinhTrangBaiSPDropDownList.Text.Trim().Length == 0)
            {
                output = false;
            }


            return output;
            //TODO - Test
        }

        private void luuTruRButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
               
                var baiSanPham = new BaiSanPham();
                //Giải quyết tình trạng
                switch (this.TinhTrangForm)
                {
                    case TinhTrangForm.Them:
                        //Tạo mới
                        BaiSanPhamModel model = new BaiSanPhamModel(soDonHangRTextBox.Text, tenBaiInRTextBox.Text
                           , yeuCauRTextBoxCtrl.Text, duongDanFile01RTextBox.Text, duongDanFile02RTextBox.Text,
                           duongDanFile03RTextBox.Text, thoiHanRDateTime.Value, tinhTrangBaiSPDropDownList.Text);
                        //Tạo DtôCnact
                        baiSanPham.Them(model);
                        break;
                    case TinhTrangForm.Sua:
                        //Xài cái sửa
                        baiSanPhamEdited.SoDonHang = soDonHangRTextBox.Text;
                        baiSanPhamEdited.TenSanPham = tenBaiInRTextBox.Text;
                        baiSanPhamEdited.YeuCau = yeuCauRTextBoxCtrl.Text;
                        baiSanPhamEdited.DuongDanFile01 = duongDanFile01RTextBox.Text;
                        baiSanPhamEdited.DuongDanFile02 = duongDanFile02RTextBox.Text;
                        baiSanPhamEdited.DuongDanFile03 = duongDanFile03RTextBox.Text;
                        baiSanPhamEdited.ThoiHan = thoiHanRDateTime.Value;
                        baiSanPhamEdited.TinhTrangBaiSanPham = tinhTrangBaiSPDropDownList.Text;
                        baiSanPham.Sua(baiSanPhamEdited);
                        break;
                }               
               
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else
            {
                MessageBox.Show("Bạn cần điền đủ và đúng thông tin");
            }
        }

        private void TaoBaiSanPhamForm_Load(object sender, EventArgs e)
        {
            //Load điền dữ liệu nếu sửa
            if (this.TinhTrangForm == TinhTrangForm.Sua)
            {
                soDonHangRTextBox.Text = baiSanPhamEdited.SoDonHang;
                tenBaiInRTextBox.Text = baiSanPhamEdited.TenSanPham;
                yeuCauRTextBoxCtrl.Text = baiSanPhamEdited.YeuCau;
                duongDanFile01RTextBox.Text = baiSanPhamEdited.DuongDanFile01;
                duongDanFile02RTextBox.Text = baiSanPhamEdited.DuongDanFile02;
                duongDanFile03RTextBox.Text = baiSanPhamEdited.DuongDanFile03;
                tinhTrangBaiSPDropDownList.Text = baiSanPhamEdited.TinhTrangBaiSanPham;
                thoiHanRDateTime.Value = baiSanPhamEdited.ThoiHan;
                //Enable
                tinhTrangBaiSPDropDownList.Enabled = true;
                //
                titleRLabel.Text = $"SỬA BÀI SẢN PHẨM ID[{baiSanPhamEdited.Id}]";
                titleRLabel.Left = (this.ClientSize.Width - titleRLabel.Width) / 2;
            }
            else
            {
                //Lock cboTinhTrang
                tinhTrangBaiSPDropDownList.Enabled = false;
            }
        }
    }
}
