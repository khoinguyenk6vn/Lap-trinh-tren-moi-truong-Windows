namespace WinFormsApp1
{
    partial class frmlistview
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
            lvDanhSach = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            SuspendLayout();
            // 
            // lvDanhSach
            // 
            lvDanhSach.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvDanhSach.FullRowSelect = true;
            lvDanhSach.GridLines = true;
            lvDanhSach.Location = new Point(12, 47);
            lvDanhSach.Name = "lvDanhSach";
            lvDanhSach.Size = new Size(455, 281);
            lvDanhSach.TabIndex = 0;
            lvDanhSach.UseCompatibleStateImageBehavior = false;
            lvDanhSach.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Last Name";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "First Name";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Phone";
            columnHeader3.Width = 150;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(507, 72);
            txtLastName.Name = "txtLastName";
            txtLastName.RightToLeft = RightToLeft.No;
            txtLastName.Size = new Size(196, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(507, 139);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(196, 27);
            txtFirstName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(507, 213);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(196, 27);
            txtPhone.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 49);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 116);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 190);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Phone";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(487, 299);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(587, 299);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(687, 299);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xoa";
            btnXoa.TextAlign = ContentAlignment.BottomCenter;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmlistview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lvDanhSach);
            Name = "frmlistview";
            Text = "frmlistview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvDanhSach;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}