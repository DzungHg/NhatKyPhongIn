namespace NhatKyPhongIn.WFUI
{
    partial class BangDieuKhienBaiSanPhamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.locBaiSanPhamDataFilter = new Telerik.WinControls.UI.RadDataFilter();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.baiSanPhamRGridView = new Telerik.WinControls.UI.RadGridView();
            this.taoBaiSanPhamRButton = new Telerik.WinControls.UI.RadButton();
            this.titleRLabel = new Telerik.WinControls.UI.RadLabel();
            this.suaBaiSanPhamRButton = new Telerik.WinControls.UI.RadButton();
            this.dongFormRButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locBaiSanPhamDataFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baiSanPhamRGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiSanPhamRGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taoBaiSanPhamRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleRLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suaBaiSanPhamRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongFormRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Location = new System.Drawing.Point(9, 72);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(625, 366);
            this.radSplitContainer1.TabIndex = 4;
            this.radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.locBaiSanPhamDataFilter);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(241, 366);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.1118547F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-59, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // locBaiSanPhamDataFilter
            // 
            this.locBaiSanPhamDataFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locBaiSanPhamDataFilter.Location = new System.Drawing.Point(0, 0);
            this.locBaiSanPhamDataFilter.Name = "locBaiSanPhamDataFilter";
            this.locBaiSanPhamDataFilter.Size = new System.Drawing.Size(241, 366);
            this.locBaiSanPhamDataFilter.TabIndex = 1;
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.baiSanPhamRGridView);
            this.splitPanel2.Location = new System.Drawing.Point(245, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(380, 366);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.1118547F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(59, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // baiSanPhamRGridView
            // 
            this.baiSanPhamRGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baiSanPhamRGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.baiSanPhamRGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.baiSanPhamRGridView.Name = "baiSanPhamRGridView";
            this.baiSanPhamRGridView.Size = new System.Drawing.Size(380, 366);
            this.baiSanPhamRGridView.TabIndex = 2;
            // 
            // taoBaiSanPhamRButton
            // 
            this.taoBaiSanPhamRButton.Location = new System.Drawing.Point(200, 42);
            this.taoBaiSanPhamRButton.Name = "taoBaiSanPhamRButton";
            this.taoBaiSanPhamRButton.Size = new System.Drawing.Size(110, 24);
            this.taoBaiSanPhamRButton.TabIndex = 10;
            this.taoBaiSanPhamRButton.Text = "Tạo Bài Sản Phẩm";
            // 
            // titleRLabel
            // 
            this.titleRLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleRLabel.Location = new System.Drawing.Point(200, 6);
            this.titleRLabel.Name = "titleRLabel";
            this.titleRLabel.Size = new System.Drawing.Size(317, 30);
            this.titleRLabel.TabIndex = 11;
            this.titleRLabel.Text = "BẢNG ĐIỀU KHIỂN BÀI SẢN PHẨM";
            // 
            // suaBaiSanPhamRButton
            // 
            this.suaBaiSanPhamRButton.Location = new System.Drawing.Point(325, 42);
            this.suaBaiSanPhamRButton.Name = "suaBaiSanPhamRButton";
            this.suaBaiSanPhamRButton.Size = new System.Drawing.Size(110, 24);
            this.suaBaiSanPhamRButton.TabIndex = 11;
            this.suaBaiSanPhamRButton.Text = "Sửa Bài Sản Phẩm";
            // 
            // dongFormRButton
            // 
            this.dongFormRButton.Location = new System.Drawing.Point(263, 478);
            this.dongFormRButton.Name = "dongFormRButton";
            this.dongFormRButton.Size = new System.Drawing.Size(110, 24);
            this.dongFormRButton.TabIndex = 12;
            this.dongFormRButton.Text = "Đóng";
            // 
            // BangDieuKhienBaiSanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 514);
            this.Controls.Add(this.dongFormRButton);
            this.Controls.Add(this.suaBaiSanPhamRButton);
            this.Controls.Add(this.titleRLabel);
            this.Controls.Add(this.taoBaiSanPhamRButton);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "BangDieuKhienBaiSanPhamForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Bảng Điều Khiển Bài In";
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locBaiSanPhamDataFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baiSanPhamRGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiSanPhamRGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taoBaiSanPhamRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleRLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suaBaiSanPhamRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongFormRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadDataFilter locBaiSanPhamDataFilter;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadGridView baiSanPhamRGridView;
        private Telerik.WinControls.UI.RadButton taoBaiSanPhamRButton;
        private Telerik.WinControls.UI.RadLabel titleRLabel;
        private Telerik.WinControls.UI.RadButton suaBaiSanPhamRButton;
        private Telerik.WinControls.UI.RadButton dongFormRButton;
    }
}
