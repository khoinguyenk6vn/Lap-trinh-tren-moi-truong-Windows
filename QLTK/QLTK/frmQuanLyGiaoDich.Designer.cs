namespace QLTK
{
    partial class frmQuanLyGiaoDich
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
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            cácGiaoDịchGửiTiềnToolStripMenuItem = new ToolStripMenuItem();
            sốDưCuốiKỳToolStripMenuItem = new ToolStripMenuItem();
            xuấtBáoCáoToolStripMenuItem = new ToolStripMenuItem();
            xuấtExcelToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            grpThongTin = new GroupBox();
            btnThemMoi = new Button();
            txtNoiDung = new TextBox();
            txtSoTien = new TextBox();
            cboLoaiGD = new ComboBox();
            cboSTK = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvGiaoDich = new DataGridView();
            menuStrip1.SuspendLayout();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoDich).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(774, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cácGiaoDịchGửiTiềnToolStripMenuItem, sốDưCuốiKỳToolStripMenuItem, xuấtBáoCáoToolStripMenuItem, xuấtExcelToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(93, 24);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // cácGiaoDịchGửiTiềnToolStripMenuItem
            // 
            cácGiaoDịchGửiTiềnToolStripMenuItem.Name = "cácGiaoDịchGửiTiềnToolStripMenuItem";
            cácGiaoDịchGửiTiềnToolStripMenuItem.ShortcutKeys = Keys.F1;
            cácGiaoDịchGửiTiềnToolStripMenuItem.Size = new Size(265, 26);
            cácGiaoDịchGửiTiềnToolStripMenuItem.Text = "Các giao dịch Gửi Tiền";
            // 
            // sốDưCuốiKỳToolStripMenuItem
            // 
            sốDưCuốiKỳToolStripMenuItem.Name = "sốDưCuốiKỳToolStripMenuItem";
            sốDưCuốiKỳToolStripMenuItem.ShortcutKeys = Keys.F2;
            sốDưCuốiKỳToolStripMenuItem.Size = new Size(265, 26);
            sốDưCuốiKỳToolStripMenuItem.Text = "Số Dư Cuối Kỳ";
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            xuấtBáoCáoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            xuấtBáoCáoToolStripMenuItem.Size = new Size(265, 26);
            xuấtBáoCáoToolStripMenuItem.Text = "Xuất Báo cáo";
            // 
            // xuấtExcelToolStripMenuItem
            // 
            xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
            xuấtExcelToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            xuấtExcelToolStripMenuItem.Size = new Size(265, 26);
            xuấtExcelToolStripMenuItem.Text = "Xuất Excel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 54);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 1;
            label1.Text = "Thông tin Giao dịch";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(btnThemMoi);
            grpThongTin.Controls.Add(txtNoiDung);
            grpThongTin.Controls.Add(txtSoTien);
            grpThongTin.Controls.Add(cboLoaiGD);
            grpThongTin.Controls.Add(cboSTK);
            grpThongTin.Controls.Add(label5);
            grpThongTin.Controls.Add(label4);
            grpThongTin.Controls.Add(label3);
            grpThongTin.Controls.Add(label2);
            grpThongTin.Location = new Point(12, 119);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(250, 317);
            grpThongTin.TabIndex = 2;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin giao dịch";
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(73, 256);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(94, 29);
            btnThemMoi.TabIndex = 8;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(99, 161);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(125, 27);
            txtNoiDung.TabIndex = 7;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(81, 119);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(125, 27);
            txtSoTien.TabIndex = 6;
            // 
            // cboLoaiGD
            // 
            cboLoaiGD.FormattingEnabled = true;
            cboLoaiGD.Location = new Point(129, 75);
            cboLoaiGD.Name = "cboLoaiGD";
            cboLoaiGD.Size = new Size(115, 28);
            cboLoaiGD.TabIndex = 5;
            // 
            // cboSTK
            // 
            cboSTK.FormattingEnabled = true;
            cboSTK.Location = new Point(73, 36);
            cboSTK.Name = "cboSTK";
            cboSTK.Size = new Size(151, 28);
            cboSTK.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 164);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 3;
            label5.Text = "Nội dung";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 122);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 2;
            label4.Text = "Số tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 78);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 1;
            label3.Text = "Loại giao dịch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 39);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 0;
            label2.Text = "Số TK";
            // 
            // dgvGiaoDich
            // 
            dgvGiaoDich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiaoDich.Location = new Point(268, 114);
            dgvGiaoDich.Name = "dgvGiaoDich";
            dgvGiaoDich.RowHeadersWidth = 51;
            dgvGiaoDich.Size = new Size(494, 322);
            dgvGiaoDich.TabIndex = 3;
            // 
            // frmQuanLyGiaoDich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 448);
            Controls.Add(dgvGiaoDich);
            Controls.Add(grpThongTin);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmQuanLyGiaoDich";
            Text = "frmQuanLyGiaoDich";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoDich).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private Label label1;
        private GroupBox grpThongTin;
        private Label label2;
        private TextBox txtNoiDung;
        private TextBox txtSoTien;
        private ComboBox cboLoaiGD;
        private ComboBox cboSTK;
        private Label label5;
        private Label label4;
        private Label label3;
        private ToolStripMenuItem cácGiaoDịchGửiTiềnToolStripMenuItem;
        private Button btnThemMoi;
        private DataGridView dgvGiaoDich;
        private ToolStripMenuItem sốDưCuốiKỳToolStripMenuItem;
        private ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private ToolStripMenuItem xuấtExcelToolStripMenuItem;
    }
}