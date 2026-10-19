namespace Lab05_02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuHeThong = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaoMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDinhDang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFont = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbFonts = new System.Windows.Forms.ToolStripComboBox();
            this.cmbSize = new System.Windows.Forms.ToolStripComboBox();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();

            this.richText = new System.Windows.Forms.RichTextBox();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSoTu = new System.Windows.Forms.ToolStripStatusLabel();

            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();

            this.menuHeThong.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // menuHeThong
            // =====================================================

            this.menuHeThong.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.hệThốngToolStripMenuItem,
                    this.menuDinhDang
                });

            this.menuHeThong.Location = new System.Drawing.Point(0, 0);
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(900, 28);
            this.menuHeThong.TabIndex = 0;

            // =====================================================
            // Hệ Thống
            // =====================================================

            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.menuTaoMoi,
                    this.menuMo,
                    this.menuLuu,
                    this.menuThoat
                });

            this.hệThốngToolStripMenuItem.Name =
                "hệThốngToolStripMenuItem";

            this.hệThốngToolStripMenuItem.Size =
                new System.Drawing.Size(88, 24);

            this.hệThốngToolStripMenuItem.Text =
                "Hệ Thống";

            // =====================================================
            // Tạo mới
            // =====================================================

            this.menuTaoMoi.Name = "menuTaoMoi";
            this.menuTaoMoi.Size =
                new System.Drawing.Size(160, 26);

            this.menuTaoMoi.Text = "Tạo mới";

            this.menuTaoMoi.Click +=
                new System.EventHandler(this.menuTaoMoi_Click);

            // =====================================================
            // Mở
            // =====================================================

            this.menuMo.Name = "menuMo";
            this.menuMo.Size =
                new System.Drawing.Size(160, 26);

            this.menuMo.Text = "Mở tập tin";

            this.menuMo.Click +=
                new System.EventHandler(this.menuMo_Click);

            // =====================================================
            // Lưu
            // =====================================================

            this.menuLuu.Name = "menuLuu";
            this.menuLuu.Size =
                new System.Drawing.Size(160, 26);

            this.menuLuu.Text = "Lưu";

            this.menuLuu.Click +=
                new System.EventHandler(this.menuLuu_Click);

            // =====================================================
            // Thoát
            // =====================================================

            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size =
                new System.Drawing.Size(160, 26);

            this.menuThoat.Text = "Thoát";

            this.menuThoat.Click +=
                new System.EventHandler(this.menuThoat_Click);

            // =====================================================
            // Định Dạng
            // =====================================================

            this.menuDinhDang.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.menuFont
                });

            this.menuDinhDang.Name = "menuDinhDang";
            this.menuDinhDang.Size =
                new System.Drawing.Size(94, 24);

            this.menuDinhDang.Text =
                "Định Dạng";

            // =====================================================
            // Font
            // =====================================================

            this.menuFont.Name = "menuFont";
            this.menuFont.Size =
                new System.Drawing.Size(160, 26);

            this.menuFont.Text = "Font";

            this.menuFont.Click +=
                new System.EventHandler(this.menuFont_Click);

            // =====================================================
            // TOOLSTRIP
            // =====================================================

            this.toolStrip1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.btnNew,
                    this.btnOpen,
                    this.btnSave,
                    this.toolStripSeparator1,
                    this.cmbFonts,
                    this.cmbSize,
                    this.btnBold,
                    this.btnItalic,
                    this.btnUnderline
                });

            this.toolStrip1.Location =
                new System.Drawing.Point(0, 28);

            this.toolStrip1.Name = "toolStrip1";

            this.toolStrip1.Size =
                new System.Drawing.Size(900, 30);

            this.toolStrip1.TabIndex = 1;

            // =====================================================
            // NEW
            // =====================================================

            this.btnNew.Name = "btnNew";

            this.btnNew.Size =
                new System.Drawing.Size(45, 27);

            this.btnNew.Text = "New";

            this.btnNew.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            this.btnNew.Click +=
                new System.EventHandler(this.btnNew_Click);

            // =====================================================
            // OPEN
            // =====================================================

            this.btnOpen.Name = "btnOpen";

            this.btnOpen.Size =
                new System.Drawing.Size(50, 27);

            this.btnOpen.Text = "Open";

            this.btnOpen.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            this.btnOpen.Click +=
                new System.EventHandler(this.btnOpen_Click);

            // =====================================================
            // SAVE
            // =====================================================

            this.btnSave.Name = "btnSave";

            this.btnSave.Size =
                new System.Drawing.Size(45, 27);

            this.btnSave.Text = "Save";

            this.btnSave.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            this.btnSave.Click +=
                new System.EventHandler(this.btnSave_Click);

            // =====================================================
            // SEPARATOR
            // =====================================================

            this.toolStripSeparator1.Name =
                "toolStripSeparator1";

            this.toolStripSeparator1.Size =
                new System.Drawing.Size(6, 27);

            // =====================================================
            // FONT COMBOBOX
            // =====================================================

            this.cmbFonts.Name = "cmbFonts";

            this.cmbFonts.Size =
                new System.Drawing.Size(160, 28);

            this.cmbFonts.Text = "Tahoma";

            this.cmbFonts.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbFonts_SelectedIndexChanged);

            // =====================================================
            // SIZE COMBOBOX
            // =====================================================

            this.cmbSize.Name = "cmbSize";

            this.cmbSize.Size =
                new System.Drawing.Size(70, 28);

            this.cmbSize.Text = "14";

            this.cmbSize.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbSize_SelectedIndexChanged);

            // =====================================================
            // BOLD
            // =====================================================

            this.btnBold.Name = "btnBold";

            this.btnBold.Size =
                new System.Drawing.Size(30, 27);

            this.btnBold.Text = "B";

            this.btnBold.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            this.btnBold.Click +=
                new System.EventHandler(this.btnBold_Click);

            // =====================================================
            // ITALIC
            // =====================================================

            this.btnItalic.Name = "btnItalic";

            this.btnItalic.Size =
                new System.Drawing.Size(30, 27);

            this.btnItalic.Text = "I";

            this.btnItalic.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            this.btnItalic.Click +=
                new System.EventHandler(this.btnItalic_Click);

            // =====================================================
            // UNDERLINE
            // =====================================================

            this.btnUnderline.Name = "btnUnderline";

            this.btnUnderline.Size =
                new System.Drawing.Size(30, 27);

            this.btnUnderline.Text = "U";

            this.btnUnderline.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            this.btnUnderline.Click +=
                new System.EventHandler(this.btnUnderline_Click);

            // =====================================================
            // RICHTEXTBOX
            // =====================================================

            this.richText.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.richText.Font =
                new System.Drawing.Font(
                    "Tahoma",
                    14F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point
                );

            this.richText.Location =
                new System.Drawing.Point(0, 58);

            this.richText.Name = "richText";

            this.richText.ScrollBars =
                System.Windows.Forms.RichTextBoxScrollBars.Both;

            this.richText.Size =
                new System.Drawing.Size(900, 386);

            this.richText.TabIndex = 2;

            this.richText.Text = "";

            this.richText.TextChanged +=
                new System.EventHandler(
                    this.richText_TextChanged);

            // =====================================================
            // STATUS STRIP
            // =====================================================

            this.statusStrip1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.lblSoTu
                });

            this.statusStrip1.Location =
                new System.Drawing.Point(0, 444);

            this.statusStrip1.Name =
                "statusStrip1";

            this.statusStrip1.Size =
                new System.Drawing.Size(900, 26);

            this.statusStrip1.TabIndex = 3;

            // =====================================================
            // LABEL SỐ TỪ
            // =====================================================

            this.lblSoTu.Name =
                "lblSoTu";

            this.lblSoTu.Size =
                new System.Drawing.Size(95, 20);

            this.lblSoTu.Text =
                "Tổng số từ: 0";

            // =====================================================
            // OPEN FILE DIALOG
            // =====================================================

            this.openFileDialog1.Title =
                "Mở tập tin";

            this.openFileDialog1.FileName = "";

            this.openFileDialog1.Filter =
                "Rich Text Format (*.rtf)|*.rtf|" +
                "Text files (*.txt)|*.txt";

            // =====================================================
            // SAVE FILE DIALOG
            // =====================================================

            this.saveFileDialog1.Title =
                "Lưu văn bản";

            this.saveFileDialog1.FileName =
                "VanBan.rtf";

            this.saveFileDialog1.Filter =
                "Rich Text Format (*.rtf)|*.rtf";

            this.saveFileDialog1.DefaultExt =
                "rtf";

            this.saveFileDialog1.AddExtension =
                true;

            // =====================================================
            // FORM
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(900, 470);

            this.Controls.Add(this.richText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuHeThong);

            this.MainMenuStrip =
                this.menuHeThong;

            this.Name = "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Soạn thảo văn bản";

            this.menuHeThong.ResumeLayout(false);
            this.menuHeThong.PerformLayout();

            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();

            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTaoMoi;
        private System.Windows.Forms.ToolStripMenuItem menuMo;
        private System.Windows.Forms.ToolStripMenuItem menuLuu;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuDinhDang;
        private System.Windows.Forms.ToolStripMenuItem menuFont;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cmbFonts;
        private System.Windows.Forms.ToolStripComboBox cmbSize;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;

        private System.Windows.Forms.RichTextBox richText;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSoTu;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}