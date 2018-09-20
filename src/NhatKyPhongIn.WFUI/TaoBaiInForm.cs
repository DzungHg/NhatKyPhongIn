using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace NhatKyPhongIn.WFUI
{
    public partial class TaoBaiInForm : Telerik.WinControls.UI.RadForm
    {
        public TaoBaiInForm()
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
            if (dienGiaiRTextBoxCtrl.Text.Length <= 0)
            {
                output = false;
            }
            if (tenNguoiLamFileRTextBox.Text.Length <= 0)
            {
                output = false;
            }

            float toChayRong = 0;
            bool toChayRongValidNumber = float.TryParse(toChayRongRTextBox.Text, out toChayRong);
            if (toChayRongValidNumber == false)
            {
                output = false;
            }
            if (toChayRong <= 0)
            {
                output = false;
            }

            float toChayDai = 0;
            bool toChayDaiValidNumber = float.TryParse(toChayDaiRTextBox.Text, out toChayDai);
            if (toChayDaiValidNumber == false)
            {
                output = false;
            }
            if (toChayDai <= 0)
            {
                output = false;
            }

            int soToChayCanIn = 0;
            bool soToChayCanInValidNumber = int.TryParse(soToChayCanInRTextBox.Text, out soToChayCanIn);
            if (soToChayCanInValidNumber == false)
            {
                output = false;
            }
            if (soToChayCanIn <= 0)
            {
                output = false;
            }

            int soToChayBuHao = 0;
            bool soToChayBuHaoValidNumber = int.TryParse(soToChayBuHaoRTextBox.Text, out soToChayBuHao);
            if (soToChayBuHaoValidNumber == false)
            {
                output = false;
            }
            if (soToChayBuHao <= 0)
            {
                output = false;
            }
            int soMatIn = 0;
            bool soMatInValidNumber = int.TryParse(soMatInRTextBox.Text, out soMatIn);
            if (soMatInValidNumber == false)
            {
                output = false;
            }
            if (soMatIn <= 0 || soMatIn >2)
            {
                output = false;
            }

            return output;
            //TODO - Test
        }
    }
}
