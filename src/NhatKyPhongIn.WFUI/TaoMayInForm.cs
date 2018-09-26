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
    public partial class TaoMayInForm : Telerik.WinControls.UI.RadForm
    {
        public TinhTrangForm TinhTrangForm { get; set; }
        public MayInModel MayInEdited { get; set; }
        public TaoMayInForm()
        {
            InitializeComponent();

            InitializeFormData();
        }
        private void InitializeFormData()
        {
            //Bind the account level settings
            foreach (DonViTinhClick donVi in Enum.GetValues(typeof(DonViTinhClick)))
            {
                donViDemClickSPDropDownList.Items.Add(donVi.ToString());
                donViDemClickSPDropDownList.SelectedIndex = 0;
            }
        }

        private bool ValidateForm()
        {
            var output = true;
            if (tenMayInRTextBox.Text.Trim().Length ==0)
            {
                output = false;
            }
            if (maMayInRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (moTaRTextBoxCtrl.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (donViDemClickSPDropDownList.Text.Length == 0)
            {
                output = false;
            }
            int thuTu = 0;
            bool validSoThuTu = int.TryParse(thuTuSapXemRTextBox.Text, out thuTu);
            if (!validSoThuTu)
            {
                output = false;
            }

            return output;
        }

        private void luuTruRButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var mayIn = new MayIn();

                switch (this.TinhTrangForm)
                {
                    case TinhTrangForm.Them:
                        var model = new MayInModel(tenMayInRTextBox.Text, maMayInRTextBox.Text, moTaRTextBoxCtrl.Text,
                            donViDemClickSPDropDownList.Text, ngungHoatDongCheckBox.Checked, int.Parse(thuTuSapXemRTextBox.Text));


                        mayIn.Them(model);
                        break;
                    case TinhTrangForm.Sua:
                        this.MayInEdited.TenMayIn = tenMayInRTextBox.Text;
                        this.MayInEdited.MaMayIn = maMayInRTextBox.Text;
                        this.MayInEdited.MoTa = moTaRTextBoxCtrl.Text;
                        this.MayInEdited.DonViDemClick = donViDemClickSPDropDownList.Text;
                        this.MayInEdited.NgungHoatDong = ngungHoatDongCheckBox.Checked;
                        this.MayInEdited.ThuTuSapXep = int.Parse(thuTuSapXemRTextBox.Text);

                        mayIn.Sua(this.MayInEdited);
                        break;
                }//Switch
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Bạn phải điền đủ thông tin");
        }

        private void TaoMayInForm_Load(object sender, EventArgs e)
        {
            switch (this.TinhTrangForm)
            {

                case TinhTrangForm.Sua:
                    tieuDeFormRLabel.Text = $"SỬA MÁY IN [ID: {this.MayInEdited.Id}]";
                    tieuDeFormRLabel.Left = (this.ClientSize.Width - tieuDeFormRLabel.Width) / 2;
                    tenMayInRTextBox.Text = this.MayInEdited.TenMayIn;
                    maMayInRTextBox.Text = this.MayInEdited.MaMayIn;
                    moTaRTextBoxCtrl.Text = this.MayInEdited.MoTa;
                    donViDemClickSPDropDownList.Text = this.MayInEdited.DonViDemClick;
                    thuTuSapXemRTextBox.Text = this.MayInEdited.ThuTuSapXep.ToString();
                    ngungHoatDongCheckBox.Checked = this.MayInEdited.NgungHoatDong;
                    break;
                case TinhTrangForm.Them:

                    tieuDeFormRLabel.Left = (this.ClientSize.Width - tieuDeFormRLabel.Width) / 2;
                    break;

            }
        }
    }
}
