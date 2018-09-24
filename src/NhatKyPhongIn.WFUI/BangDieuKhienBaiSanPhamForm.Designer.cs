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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.taoBaiSanPhamRButton = new Telerik.WinControls.UI.RadButton();
            this.titleRLabel = new Telerik.WinControls.UI.RadLabel();
            this.suaBaiSanPhamRButton = new Telerik.WinControls.UI.RadButton();
            this.dongFormRButton = new Telerik.WinControls.UI.RadButton();
            this.baiSanPhamRGridView = new Telerik.WinControls.UI.RadGridView();
            this.headRPanel = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.taoBaiSanPhamRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleRLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suaBaiSanPhamRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongFormRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiSanPhamRGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiSanPhamRGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headRPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // taoBaiSanPhamRButton
            // 
            this.taoBaiSanPhamRButton.Location = new System.Drawing.Point(200, 42);
            this.taoBaiSanPhamRButton.Name = "taoBaiSanPhamRButton";
            this.taoBaiSanPhamRButton.Size = new System.Drawing.Size(110, 24);
            this.taoBaiSanPhamRButton.TabIndex = 10;
            this.taoBaiSanPhamRButton.Text = "Tạo Bài Sản Phẩm";
            this.taoBaiSanPhamRButton.Click += new System.EventHandler(this.taoBaiSanPhamRButton_Click);
            // 
            // titleRLabel
            // 
            this.titleRLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleRLabel.Location = new System.Drawing.Point(168, 6);
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
            this.suaBaiSanPhamRButton.Click += new System.EventHandler(this.suaBaiSanPhamRButton_Click);
            // 
            // dongFormRButton
            // 
            this.dongFormRButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dongFormRButton.Location = new System.Drawing.Point(263, 478);
            this.dongFormRButton.Name = "dongFormRButton";
            this.dongFormRButton.Size = new System.Drawing.Size(110, 24);
            this.dongFormRButton.TabIndex = 12;
            this.dongFormRButton.Text = "Đóng";
            // 
            // baiSanPhamRGridView
            // 
            this.baiSanPhamRGridView.Location = new System.Drawing.Point(27, 131);
            // 
            // 
            // 
            this.baiSanPhamRGridView.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.baiSanPhamRGridView.Name = "baiSanPhamRGridView";
            this.baiSanPhamRGridView.ReadOnly = true;
            this.baiSanPhamRGridView.Size = new System.Drawing.Size(578, 322);
            this.baiSanPhamRGridView.TabIndex = 13;
            // 
            // headRPanel
            // 
            this.headRPanel.Location = new System.Drawing.Point(27, 87);
            this.headRPanel.Name = "headRPanel";
            this.headRPanel.Size = new System.Drawing.Size(578, 38);
            this.headRPanel.TabIndex = 14;
            // 
            // BangDieuKhienBaiSanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 514);
            this.Controls.Add(this.headRPanel);
            this.Controls.Add(this.baiSanPhamRGridView);
            this.Controls.Add(this.dongFormRButton);
            this.Controls.Add(this.suaBaiSanPhamRButton);
            this.Controls.Add(this.titleRLabel);
            this.Controls.Add(this.taoBaiSanPhamRButton);
            this.Name = "BangDieuKhienBaiSanPhamForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Bảng Điều Khiển Bài In";
            this.Load += new System.EventHandler(this.BangDieuKhienBaiSanPhamForm_Load);
            this.Resize += new System.EventHandler(this.BangDieuKhienBaiSanPhamForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.taoBaiSanPhamRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleRLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suaBaiSanPhamRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongFormRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiSanPhamRGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiSanPhamRGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headRPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadButton taoBaiSanPhamRButton;
        private Telerik.WinControls.UI.RadLabel titleRLabel;
        private Telerik.WinControls.UI.RadButton suaBaiSanPhamRButton;
        private Telerik.WinControls.UI.RadButton dongFormRButton;
        private Telerik.WinControls.UI.RadGridView baiSanPhamRGridView;
        private Telerik.WinControls.UI.RadPanel headRPanel;
    }
}
