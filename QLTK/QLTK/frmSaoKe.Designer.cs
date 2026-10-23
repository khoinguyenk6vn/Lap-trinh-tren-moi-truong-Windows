namespace QLTK
{
    partial class frmSaoKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblChonSTK = new Label();
            cboSTK = new ComboBox();
            btnXem = new Button();
            pnlBaoCao = new Panel();
            lblNganHang = new Label();
            lblThongTin = new Label();
            dgvSaoKe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSaoKe).BeginInit();
            SuspendLayout();
            // lblChonSTK
            lblChonSTK.AutoSize = true;
            lblChonSTK.Location = new Point(40, 35);
            lblChonSTK.Name = "lblChonSTK";
            lblChonSTK.Size = new Size(127, 20);
            lblChonSTK.Text = "Chọn số tài khoản";
            // cboSTK
            cboSTK.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSTK.Location = new Point(180, 32);
            cboSTK.Name = "cboSTK";
            cboSTK.Size = new Size(200, 28);
            // btnXem
            btnXem.Location = new Point(400, 31);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(94, 29);
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            // pnlBaoCao
            pnlBaoCao.Location = new Point(12, 75);
            pnlBaoCao.Name = "pnlBaoCao";
            pnlBaoCao.Size = new Size(776, 363);
            // lblNganHang
            lblNganHang.AutoSize = true;
            lblNganHang.Location = new Point(15, 12);
            lblNganHang.Name = "lblNganHang";
            lblNganHang.Size = new Size(0, 20);
            lblNganHang.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            // lblThongTin
            lblThongTin.AutoSize = true;
            lblThongTin.Location = new Point(15, 38);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(0, 20);
            // dgvSaoKe
            dgvSaoKe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSaoKe.Location = new Point(12, 68);
            dgvSaoKe.Name = "dgvSaoKe";
            dgvSaoKe.Size = new Size(750, 280);
            dgvSaoKe.RowHeadersWidth = 51;
            pnlBaoCao.Controls.Add(lblNganHang);
            pnlBaoCao.Controls.Add(lblThongTin);
            pnlBaoCao.Controls.Add(dgvSaoKe);
            // frmSaoKe
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlBaoCao);
            Controls.Add(btnXem);
            Controls.Add(cboSTK);
            Controls.Add(lblChonSTK);
            Name = "frmSaoKe";
            Text = "Sao kê tài khoản";
            ((System.ComponentModel.ISupportInitialize)dgvSaoKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblChonSTK;
        private ComboBox cboSTK;
        private Button btnXem;
        private Panel pnlBaoCao;
        private Label lblNganHang;
        private Label lblThongTin;
        private DataGridView dgvSaoKe;
    }
}