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
        private List<BaiSanPhamModel> danhSachBaiSanPham = new BaiSanPham().DocTatCa();
        public BangDieuKhienBaiSanPhamForm()
        {
            InitializeComponent();
            //Đấu nối các danh sách
            DauNoiList();
        }

        public void DauNoiList()
        {
            //locBaiSanPhamDataFilter.DataSource = null;
            //locBaiSanPhamDataFilter.DataSource = danhSachBaiSanPham;
            baiSanPhamRGridView.DataSource = null;//bẩy khi thay đổi
            baiSanPhamRGridView.DataSource = danhSachBaiSanPham;
            //locBaiSanPhamDataFilter.DataSource = danhSachBaiSanPham;


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
            

            titleRLabel.Left = (this.ClientSize.Width - titleRLabel.Width) / 2;
            titleRLabel.Top = 5;

            taoBaiSanPhamRButton.Top = titleRLabel.Top + titleRLabel.Height + 10;
            suaBaiSanPhamRButton.Top = taoBaiSanPhamRButton.Top;

            headRPanel.Width = this.ClientSize.Width - 4;
            headRPanel.Left = 2;
            headRPanel.Top = taoBaiSanPhamRButton.Top + taoBaiSanPhamRButton.Height + 4;
            baiSanPhamRGridView.Width = headRPanel.Width;
            baiSanPhamRGridView.Height = this.ClientSize.Height - (headRPanel.Top + headRPanel.Height + 4) - (dongFormRButton.Height + 8);
            baiSanPhamRGridView.Left = 4;
            baiSanPhamRGridView.Top = headRPanel.Top + headRPanel.Height + 4;
            /*radSplitCont1.Width = this.ClientSize.Width - 4;
            radSplitCont1.Left = 2;
            radSplitCont1.Top = taoBaiSanPhamRButton.Top + taoBaiSanPhamRButton.Height + 4;

            splitPanel1.Width = sPanel1Width;
            radSplitCont1.Height = this.ClientSize.Height - (taoBaiSanPhamRButton.Top + taoBaiSanPhamRButton.Height + 4) - (dongFormRButton.Height + 8);
            */

            //thay đổi left của button
            //taoBaiSanPhamRButton.Left = (this.ClientSize.Width - (taoBaiSanPhamRButton.Width + suaBaiSanPhamRButton.Width + 4))/2;
            taoBaiSanPhamRButton.Left = baiSanPhamRGridView.Left + 4;
            suaBaiSanPhamRButton.Left = taoBaiSanPhamRButton.Left + taoBaiSanPhamRButton.Width + 4;
            //dịch tiếp


            dongFormRButton.Left = (this.ClientSize.Width - dongFormRButton.Width) / 2;
            dongFormRButton.Top = baiSanPhamRGridView.Top + baiSanPhamRGridView.Height + 4;



        }

        private void BangDieuKhienBaiSanPhamForm_Load(object sender, EventArgs e)
        {
            //Sắp xếp kích thước vị trí
            FormThayDoiKichThuoc();
            //filter
            //locBaiSanPhamDataFilter.DataSource = danhSachBaiSanPham;
            //baiSanPhamRGridView.DataSource = locBaiSanPhamDataFilter.DataFilterElement.DataSource;
        }

        private void splitPanel2_Resize(object sender, EventArgs e)
        {
            //const int sPanel1Width = 250;
            //splitPanel1.Width = sPanel1Width;
            //splitPanel2.Width = radSplitCont1.Width - sPanel1Width;
            //thay đổi left của button
            //taoBaiSanPhamRButton.Left = radSplitCont1.Left + splitPanel1.Width + 4;
            suaBaiSanPhamRButton.Left = taoBaiSanPhamRButton.Left + taoBaiSanPhamRButton.Width + 4;
        }

        private void baiSanPhamRGridView_CreateRow(object sender, Telerik.WinControls.UI.GridViewCreateRowEventArgs e)
        {

        }

        private void baiSanPhamRGridView_CreateCell(object sender, Telerik.WinControls.UI.GridViewCreateCellEventArgs e)
        {


            if (e.Column.Name == "Id")
            {
                e.Column.HeaderText = "Id";
                e.Column.Width = 20;
            }
            if (e.Column.Name == "SoDonHang")
            {
                e.Column.HeaderText = "Số Đơn Hàng";
                e.Column.Width = 60;
            }
            if (e.Column.Name == "TenSanPham")
            {
                e.Column.HeaderText = "Tên Sản phẩm";
                e.Column.Width = 100;
            }
            if (e.Column.Name == "YeuCau")
            {
                e.Column.HeaderText = "Yêu cầu";
                e.Column.Width = 100;
            }
            if (e.Column.Name == "DuongDanFile01")
            {
                e.Column.HeaderText = "Đường dẫn file 01";
                e.Column.Width = 100;
            }
            if (e.Column.Name == "DuongDanFile02")
            {
                e.Column.HeaderText = "Đường dẫn file 02";
                e.Column.Width = 100;
            }
            if (e.Column.Name == "DuongDanFile03")
            {
                e.Column.HeaderText = "Đường dẫn file 03";
                e.Column.Width = 100;
            }
            if (e.Column.Name == "ThoiHan")
            {
                e.Column.HeaderText = "Thời hạn";
                e.Column.Width = 50;
            }
            if (e.Column.Name == "TinhTrangBaiSanPham")
            {
                e.Column.HeaderText = "Tình trạng";
                e.Column.Width = 50;
            }
        }

        private void suaBaiSanPhamRButton_Click(object sender, EventArgs e)
        {
            var selecteRow = baiSanPhamRGridView.CurrentRow;
            if (selecteRow != null)
            {
                
                var model = (BaiSanPhamModel)selecteRow.DataBoundItem;
                //MessageBox.Show($"Tên sản phẩm {model.TenSanPham} id: {model.Id}"); //Hoạt động OK
                var frm = new TaoBaiSanPhamForm();
                frm.TinhTrangForm = Common.Enums.TinhTrangForm.Sua;
                frm.baiSanPhamEdited = model;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.ShowDialog();
                
            }
        }

        private void splitPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
