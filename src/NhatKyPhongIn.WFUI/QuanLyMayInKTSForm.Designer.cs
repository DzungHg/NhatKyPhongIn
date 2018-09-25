namespace NhatKyPhongIn.WFUI
{
    partial class QuanLyMayInKTSForm
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
            this.container01RSplit = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.locMayInDataFilter = new Telerik.WinControls.UI.RadDataFilter();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.mayInRGridView = new Telerik.WinControls.UI.RadGridView();
            this.themMayInRButton = new Telerik.WinControls.UI.RadButton();
            this.titleRLabel = new Telerik.WinControls.UI.RadLabel();
            this.suaMayInRButton = new Telerik.WinControls.UI.RadButton();
            this.dongFormRButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.container01RSplit)).BeginInit();
            this.container01RSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locMayInDataFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mayInRGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayInRGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themMayInRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleRLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suaMayInRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongFormRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // container01RSplit
            // 
            this.container01RSplit.Controls.Add(this.splitPanel1);
            this.container01RSplit.Controls.Add(this.splitPanel2);
            this.container01RSplit.Location = new System.Drawing.Point(9, 97);
            this.container01RSplit.Name = "container01RSplit";
            // 
            // 
            // 
            this.container01RSplit.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.container01RSplit.Size = new System.Drawing.Size(625, 366);
            this.container01RSplit.TabIndex = 4;
            this.container01RSplit.TabStop = false;
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.locMayInDataFilter);
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
            // locMayInDataFilter
            // 
            this.locMayInDataFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locMayInDataFilter.Location = new System.Drawing.Point(0, 0);
            this.locMayInDataFilter.Name = "locMayInDataFilter";
            this.locMayInDataFilter.Size = new System.Drawing.Size(241, 366);
            this.locMayInDataFilter.TabIndex = 1;
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.mayInRGridView);
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
            // mayInRGridView
            // 
            this.mayInRGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mayInRGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.mayInRGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.mayInRGridView.Name = "mayInRGridView";
            this.mayInRGridView.ReadOnly = true;
            this.mayInRGridView.Size = new System.Drawing.Size(380, 366);
            this.mayInRGridView.TabIndex = 2;
            // 
            // themMayInRButton
            // 
            this.themMayInRButton.Location = new System.Drawing.Point(254, 70);
            this.themMayInRButton.Name = "themMayInRButton";
            this.themMayInRButton.Size = new System.Drawing.Size(110, 24);
            this.themMayInRButton.TabIndex = 10;
            this.themMayInRButton.Text = "Thêm Máy in";
            this.themMayInRButton.Click += new System.EventHandler(this.themMayInRButton_Click);
            // 
            // titleRLabel
            // 
            this.titleRLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleRLabel.Location = new System.Drawing.Point(200, 6);
            this.titleRLabel.Name = "titleRLabel";
            this.titleRLabel.Size = new System.Drawing.Size(202, 30);
            this.titleRLabel.TabIndex = 11;
            this.titleRLabel.Text = "QUẢN LÝ MÁY IN KTS";
            // 
            // suaMayInRButton
            // 
            this.suaMayInRButton.Location = new System.Drawing.Point(379, 70);
            this.suaMayInRButton.Name = "suaMayInRButton";
            this.suaMayInRButton.Size = new System.Drawing.Size(110, 24);
            this.suaMayInRButton.TabIndex = 11;
            this.suaMayInRButton.Text = "Sửa Máy In";
            this.suaMayInRButton.Click += new System.EventHandler(this.suaMayInRButton_Click);
            // 
            // dongFormRButton
            // 
            this.dongFormRButton.Location = new System.Drawing.Point(263, 478);
            this.dongFormRButton.Name = "dongFormRButton";
            this.dongFormRButton.Size = new System.Drawing.Size(110, 24);
            this.dongFormRButton.TabIndex = 12;
            this.dongFormRButton.Text = "Đóng";
            // 
            // QuanLyMayInKTSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 514);
            this.Controls.Add(this.dongFormRButton);
            this.Controls.Add(this.suaMayInRButton);
            this.Controls.Add(this.titleRLabel);
            this.Controls.Add(this.themMayInRButton);
            this.Controls.Add(this.container01RSplit);
            this.Name = "QuanLyMayInKTSForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản lý Máy in";
            this.Resize += new System.EventHandler(this.QuanLyMayInKTSForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.container01RSplit)).EndInit();
            this.container01RSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locMayInDataFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mayInRGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayInRGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themMayInRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleRLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suaMayInRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongFormRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer container01RSplit;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadDataFilter locMayInDataFilter;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadGridView mayInRGridView;
        private Telerik.WinControls.UI.RadButton themMayInRButton;
        private Telerik.WinControls.UI.RadLabel titleRLabel;
        private Telerik.WinControls.UI.RadButton suaMayInRButton;
        private Telerik.WinControls.UI.RadButton dongFormRButton;
    }
}
