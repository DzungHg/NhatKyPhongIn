namespace NhatKyPhongIn.WFUI
{
    partial class NavForm
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
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.dangNhapRMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.thoatMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.nhatKyKyMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.dangNhapRButton = new Telerik.WinControls.UI.RadButton();
            this.phongInRButton = new Telerik.WinControls.UI.RadButton();
            this.quanLyBaiInRButton = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.tenUserRLabel = new Telerik.WinControls.UI.RadLabel();
            this.menuTopRMenu = new Telerik.WinControls.UI.RadMenu();
            this.QuanLyBaiSanPharmRButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongInRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBaiInRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenUserRLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuTopRMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBaiSanPharmRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.dangNhapRMenuItem,
            this.radMenuSeparatorItem1,
            this.thoatMenuItem});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "File";
            // 
            // dangNhapRMenuItem
            // 
            this.dangNhapRMenuItem.Name = "dangNhapRMenuItem";
            this.dangNhapRMenuItem.Text = "Đăng nhập";
            this.dangNhapRMenuItem.Click += new System.EventHandler(this.baiInRMenuItem_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // thoatMenuItem
            // 
            this.thoatMenuItem.Name = "thoatMenuItem";
            this.thoatMenuItem.Text = "Thoát";
            this.thoatMenuItem.Click += new System.EventHandler(this.thoatMenuItem_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.nhatKyKyMenuItem});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Bảng Điều  Khiển";
            // 
            // nhatKyKyMenuItem
            // 
            this.nhatKyKyMenuItem.Name = "nhatKyKyMenuItem";
            this.nhatKyKyMenuItem.Text = "Nhật Ký Kỳ";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Báo Cáo";
            // 
            // dangNhapRButton
            // 
            this.dangNhapRButton.Location = new System.Drawing.Point(12, 26);
            this.dangNhapRButton.Name = "dangNhapRButton";
            this.dangNhapRButton.Size = new System.Drawing.Size(110, 84);
            this.dangNhapRButton.TabIndex = 1;
            this.dangNhapRButton.Text = "Đăng nhập";
            // 
            // phongInRButton
            // 
            this.phongInRButton.Location = new System.Drawing.Point(244, 26);
            this.phongInRButton.Name = "phongInRButton";
            this.phongInRButton.Size = new System.Drawing.Size(110, 39);
            this.phongInRButton.TabIndex = 2;
            this.phongInRButton.Text = "Phòng In";
            // 
            // quanLyBaiInRButton
            // 
            this.quanLyBaiInRButton.Location = new System.Drawing.Point(128, 71);
            this.quanLyBaiInRButton.Name = "quanLyBaiInRButton";
            this.quanLyBaiInRButton.Size = new System.Drawing.Size(110, 39);
            this.quanLyBaiInRButton.TabIndex = 3;
            this.quanLyBaiInRButton.Text = "Quản lý Bài In";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.tenUserRLabel);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 123);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(365, 33);
            this.radPanel1.TabIndex = 4;
            // 
            // tenUserRLabel
            // 
            this.tenUserRLabel.Location = new System.Drawing.Point(128, 3);
            this.tenUserRLabel.Name = "tenUserRLabel";
            this.tenUserRLabel.Size = new System.Drawing.Size(50, 18);
            this.tenUserRLabel.TabIndex = 0;
            this.tenUserRLabel.Text = "Tên User";
            // 
            // menuTopRMenu
            // 
            this.menuTopRMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3});
            this.menuTopRMenu.Location = new System.Drawing.Point(0, 0);
            this.menuTopRMenu.Name = "menuTopRMenu";
            this.menuTopRMenu.Size = new System.Drawing.Size(365, 20);
            this.menuTopRMenu.TabIndex = 0;
            // 
            // QuanLyBaiSanPharmRButton
            // 
            this.QuanLyBaiSanPharmRButton.Location = new System.Drawing.Point(128, 26);
            this.QuanLyBaiSanPharmRButton.Name = "QuanLyBaiSanPharmRButton";
            this.QuanLyBaiSanPharmRButton.Size = new System.Drawing.Size(110, 39);
            this.QuanLyBaiSanPharmRButton.TabIndex = 4;
            this.QuanLyBaiSanPharmRButton.Text = "Quản lý Bài SP";
            this.QuanLyBaiSanPharmRButton.Click += new System.EventHandler(this.QuanLyBaiSanPharmRButton_Click);
            // 
            // NavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 156);
            this.Controls.Add(this.QuanLyBaiSanPharmRButton);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.quanLyBaiInRButton);
            this.Controls.Add(this.phongInRButton);
            this.Controls.Add(this.dangNhapRButton);
            this.Controls.Add(this.menuTopRMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NavForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản Lý Nhật Ký Phòng In";
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongInRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBaiInRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenUserRLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuTopRMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBaiSanPharmRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem thoatMenuItem;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem nhatKyKyMenuItem;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem dangNhapRMenuItem;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadButton dangNhapRButton;
        private Telerik.WinControls.UI.RadButton phongInRButton;
        private Telerik.WinControls.UI.RadButton quanLyBaiInRButton;
        private Telerik.WinControls.UI.RadMenu menuTopRMenu;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel tenUserRLabel;
        private Telerik.WinControls.UI.RadButton QuanLyBaiSanPharmRButton;
    }
}