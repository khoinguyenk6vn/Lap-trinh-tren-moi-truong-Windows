namespace EFC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblHoTen = new Label();
            lblDiem = new Label();
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTaiLai = new Button();
            btnLocDat = new Button();
            dgvSinhVien = new DataGridView();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 19);
            label1.Name = "label1";
            label1.Size = new Size(324, 20);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ SINH VIÊN - EF CORE (CRUD ĐẦY ĐỦ)";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(69, 56);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(57, 20);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Location = new Point(499, 56);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(48, 20);
            lblDiem.TabIndex = 2;
            lblDiem.Text = "Điểm:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(132, 53);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 3;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(553, 53);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(125, 27);
            txtDiem.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(43, 130);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(180, 130);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(322, 130);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(462, 130);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(94, 29);
            btnTaiLai.TabIndex = 8;
            btnTaiLai.Text = "Tải lại danh sách";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnLocDat
            // 
            btnLocDat.Location = new Point(599, 130);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(137, 29);
            btnLocDat.TabIndex = 9;
            btnLocDat.Text = "Lọc SV đạt (LINQ)";
            btnLocDat.UseVisualStyleBackColor = true;
            btnLocDat.Click += btnLocDat_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(43, 179);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(693, 217);
            dgvSinhVien.TabIndex = 10;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(43, 409);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(0, 20);
            lblTrangThai.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnLocDat);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Controls.Add(lblDiem);
            Controls.Add(lblHoTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblHoTen;
        private Label lblDiem;
        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTaiLai;
        private Button btnLocDat;
        private DataGridView dgvSinhVien;
        private Label lblTrangThai;
    }
}
