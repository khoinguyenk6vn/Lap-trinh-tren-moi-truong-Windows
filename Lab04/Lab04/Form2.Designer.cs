namespace Lab04
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMSNV = new TextBox();
            txtTenNV = new TextBox();
            txtLuongCB = new TextBox();
            btnDongY = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 40);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "MSNV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 93);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 149);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Lương cơ bản";
            // 
            // txtMSNV
            // 
            txtMSNV.Location = new Point(215, 37);
            txtMSNV.Name = "txtMSNV";
            txtMSNV.Size = new Size(228, 27);
            txtMSNV.TabIndex = 3;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(215, 90);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(228, 27);
            txtTenNV.TabIndex = 4;
            // 
            // txtLuongCB
            // 
            txtLuongCB.Location = new Point(215, 146);
            txtLuongCB.Name = "txtLuongCB";
            txtLuongCB.Size = new Size(228, 27);
            txtLuongCB.TabIndex = 5;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(132, 199);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(94, 29);
            btnDongY.TabIndex = 6;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(304, 199);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 29);
            btnBoQua.TabIndex = 7;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 263);
            Controls.Add(btnBoQua);
            Controls.Add(btnDongY);
            Controls.Add(txtLuongCB);
            Controls.Add(txtTenNV);
            Controls.Add(txtMSNV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMSNV;
        private TextBox txtTenNV;
        private TextBox txtLuongCB;
        private Button btnDongY;
        private Button btnBoQua;
    }
}