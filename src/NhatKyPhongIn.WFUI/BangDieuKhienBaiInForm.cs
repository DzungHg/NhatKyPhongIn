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
    public partial class BangDieuKhienBaiInForm : Telerik.WinControls.UI.RadForm
    {
        public BangDieuKhienBaiInForm()
        {
            InitializeComponent();
        }

        private void taoBaiInRButton_Click(object sender, EventArgs e)
        {
            var frm = new TaoBaiInForm();
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
