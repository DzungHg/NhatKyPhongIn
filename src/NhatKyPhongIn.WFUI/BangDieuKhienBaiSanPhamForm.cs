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
    public partial class BangDieuKhienBaiSanPhamForm : Telerik.WinControls.UI.RadForm
    {
        public BangDieuKhienBaiSanPhamForm()
        {
            InitializeComponent();
        }

        private void taoBaiSanPhamRButton_Click(object sender, EventArgs e)
        {
            TaoBaiSanPhamForm frm = new TaoBaiSanPhamForm();
            frm.MaximizeBox = false;
            
            frm.ShowDialog();
        }
    }
}
