using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NhatKyPhongIn.WFUI.DTOContext;
using NhatKyPhongIn.WFUI.Model;

namespace NhatKyPhongIn.WFUI
{
    public partial class QuanLyMayInKTSForm : Telerik.WinControls.UI.RadForm
    {
        private MayIn nguonMayIn = new MayIn();
        public QuanLyMayInKTSForm()
        {
            InitializeComponent();
            //Đấu nối dữ liệu vô grid view
            DauNoiDuLieu();
        }
        private void DauNoiDuLieu()
        {
            mayInRGridView.DataSource = null;
            mayInRGridView.DataSource = nguonMayIn.DocTatCa();
            //TODO -- Đấu nối dữ liệu
        }

        private void themMayInRButton_Click(object sender, EventArgs e)
        {
            var frm = new TaoMayInForm();
            frm.TinhTrangForm = Common.Enums.TinhTrangForm.Them;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DauNoiDuLieu();
            }
        }

        private void QuanLyMayInKTSForm_Resize(object sender, EventArgs e)
        {
            titleRLabel.Left = (this.ClientSize.Width - titleRLabel.Width) / 2;
            titleRLabel.Top = 10;

            themMayInRButton.Top = titleRLabel.Top + titleRLabel.Height + 8;
            suaMayInRButton.Top = themMayInRButton.Top;

            container01RSplit.Width = this.ClientSize.Width - 8;
            container01RSplit.Height = this.ClientSize.Height - titleRLabel.Top - titleRLabel.Height - 4 - dongFormRButton.Top - 8;
            container01RSplit.Left = 4;
            container01RSplit.Top = themMayInRButton.Top + themMayInRButton.Height + 4;

        }

        private void suaMayInRButton_Click(object sender, EventArgs e)
        {
            if (mayInRGridView.CurrentRow != null)
            {
                var model = (MayInModel)mayInRGridView.CurrentRow.DataBoundItem;
                var frm = new TaoMayInForm();
                frm.TinhTrangForm = Common.Enums.TinhTrangForm.Sua;
                frm.MayInEdited = model;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    DauNoiDuLieu();
                }
            }
        }
    }
}
