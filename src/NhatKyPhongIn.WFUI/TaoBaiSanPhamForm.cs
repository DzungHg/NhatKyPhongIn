using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NhatKyPhongIn.Model;

namespace NhatKyPhongIn.WFUI
{
    public partial class TaoBaiSanPhamForm : Telerik.WinControls.UI.RadForm
    {
        public TaoBaiSanPhamForm()
        {
            InitializeComponent();
        }
        private bool ValidateForm()
        {
            bool output = true;

            if (soDonHangRTextBox.Text.Length <= 0)
            {
                output = false;
            }

            if (tenBaiInRTextBox.Text.Length <= 0)
            {
                output = false;
            }
            if (yeuCauRTextBoxCtrl.Text.Length <= 0)
            {
                output = false;
            }
            if (tinhTrangBaiSPDropDownList.Text.Length <= 0)
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
                BaiSanPham model = new BaiSanPham(soDonHangRTextBox.Text, tenBaiInRTextBox.Text, yeuCauRTextBoxCtrl.Text,
                    duongDanFile01RTextBox.Text, duongDanFile02RTextBox.Text, duongDanFile03RTextBox.Text);
            }
        }
    }
}
