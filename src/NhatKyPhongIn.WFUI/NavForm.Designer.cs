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
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.nhatKyNgayRMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.thoatMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.nhatKyKyMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.baiInRMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(386, 20);
            this.radMenu1.TabIndex = 0;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.baiInRMenuItem,
            this.nhatKyNgayRMenuItem,
            this.radMenuSeparatorItem1,
            this.thoatMenuItem});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "File";
            // 
            // nhatKyNgayRMenuItem
            // 
            this.nhatKyNgayRMenuItem.Name = "nhatKyNgayRMenuItem";
            this.nhatKyNgayRMenuItem.Text = "Nhật ký ngày";
            this.nhatKyNgayRMenuItem.Click += new System.EventHandler(this.nhatKyNgayRMenuItem_Click);
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
            // baiInRMenuItem
            // 
            this.baiInRMenuItem.Name = "baiInRMenuItem";
            this.baiInRMenuItem.Text = "Bài In";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Báo Cáo";
            // 
            // NavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 37);
            this.Controls.Add(this.radMenu1);
            this.Name = "NavForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản Lý Nhật Ký Phòng In";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem thoatMenuItem;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem nhatKyKyMenuItem;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem nhatKyNgayRMenuItem;
        private Telerik.WinControls.UI.RadMenuItem baiInRMenuItem;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
    }
}