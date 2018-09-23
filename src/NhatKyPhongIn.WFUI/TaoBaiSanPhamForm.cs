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
       
        public TaoBaiSanPhamForm()
        {
            InitializeComponent();

            InitializeFormData();
            //Đặt Cb
            tinhTrangBaiSPDropDownList.SelectedIndex = 0;//Đầu tiên "Nhap"
            //Lock cboTinhTrang
            tinhTrangBaiSPDropDownList.Enabled = false;
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

            if (string.IsNullOrWhiteSpace(soDonHangRTextBox.Text))
            {
                output = false;
            }

            if (string.IsNullOrWhiteSpace(tenBaiInRTextBox.Text))
            {
                output = false;
            }
            if (string.IsNullOrWhiteSpace(yeuCauRTextBoxCtrl.Text))
            {
                output = false;
            }
            if (string.IsNullOrWhiteSpace(tinhTrangBaiSPDropDownList.Text))
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
                //Giải quyết tình trạng

                BaiSanPhamModel model = new BaiSanPhamModel(soDonHangRTextBox.Text, tenBaiInRTextBox.Text
                    , yeuCauRTextBoxCtrl.Text, duongDanFile01RTextBox.Text, duongDanFile02RTextBox.Text,
                    duongDanFile03RTextBox.Text, thoiHanRDateTime.Value, tinhTrangBaiSPDropDownList.Text);
                //Thêm zô
                var baiSanPham = new BaiSanPham();
                baiSanPham.Them(model);
                //đóng form
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else
            {
                MessageBox.Show("Bạn cần điền đủ và đúng thông tin");
            }
        }
    }
}
