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
    public partial class BangDieuKhienBaiSanPhamForm : Telerik.WinControls.UI.RadForm
    {
        private BaiSanPham baiSanPham = new BaiSanPham();
        public BangDieuKhienBaiSanPhamForm()
        {
            InitializeComponent();
            //Đấu nối các danh sách
            DauNoiList();
        }

        public void DauNoiList()
        {
            baiSanPhamRGridView.DataSource = null;//bẩy khi thay đổi
            baiSanPhamRGridView.DataSource = baiSanPham.DocTatCa();
            //baiSanPhamRGridView.Columns.A
        }

        private void taoBaiSanPhamRButton_Click(object sender, EventArgs e)
        {
            TaoBaiSanPhamForm frm = new TaoBaiSanPhamForm();
            frm.MaximizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
               DauNoiList();
            }
           
        }

        private void BangDieuKhienBaiSanPhamForm_Resize(object sender, EventArgs e)
        {
            FormThayDoiKichThuoc();

        }
        private void FormThayDoiKichThuoc()
        {
            const int sPanel1Width = 250;
            
            titleRLabel.Left = (this.ClientSize.Width - titleRLabel.Width) / 2;
            titleRLabel.Top = 5;

            taoBaiSanPhamRButton.Top = titleRLabel.Top + titleRLabel.Height + 10;
            suaBaiSanPhamRButton.Top = taoBaiSanPhamRButton.Top;

            radSplitCont1.Width = this.ClientSize.Width - 4;
            radSplitCont1.Left = 2;
            radSplitCont1.Top = taoBaiSanPhamRButton.Top + taoBaiSanPhamRButton.Height + 4;
            
            splitPanel1.Width = sPanel1Width;
            radSplitCont1.Height = this.ClientSize.Height - (taoBaiSanPhamRButton.Top + taoBaiSanPhamRButton.Height + 4) - (dongFormRButton.Height + 8);

            //thay đổi left của button
            taoBaiSanPhamRButton.Left = radSplitCont1.Left + splitPanel1.Width + 4;
            suaBaiSanPhamRButton.Left = taoBaiSanPhamRButton.Left + taoBaiSanPhamRButton.Width + 4;

            dongFormRButton.Left = (this.ClientSize.Width - dongFormRButton.Width) / 2;
            dongFormRButton.Top = radSplitCont1.Top + radSplitCont1.Height + 4;

            

        }

        private void BangDieuKhienBaiSanPhamForm_Load(object sender, EventArgs e)
        {
            //Sắp xếp kích thước vị trí
            FormThayDoiKichThuoc();
        }

        private void splitPanel2_Resize(object sender, EventArgs e)
        {
            const int sPanel1Width = 250;
            //splitPanel1.Width = sPanel1Width;
            splitPanel2.Width = radSplitCont1.Width - sPanel1Width;
            //thay đổi left của button
            taoBaiSanPhamRButton.Left = radSplitCont1.Left + splitPanel1.Width + 4;
            suaBaiSanPhamRButton.Left = taoBaiSanPhamRButton.Left + taoBaiSanPhamRButton.Width + 4;
        }

        private void baiSanPhamRGridView_CreateRow(object sender, Telerik.WinControls.UI.GridViewCreateRowEventArgs e)
        {
            
        }
    }
}
