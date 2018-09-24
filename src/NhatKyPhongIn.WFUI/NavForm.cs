using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NhatKyPhongIn.WFUI
{
    public partial class NavForm : Telerik.WinControls.UI.RadForm
    {
        public NavForm()
        {
            InitializeComponent();
        }

        private void thoatMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhatKyNgayRMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void baiInRMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyBaiSanPharmRButton_Click(object sender, EventArgs e)
        {
            var frm = new BangDieuKhienBaiSanPhamForm();
            frm.ShowDialog();

        }
    }
}
