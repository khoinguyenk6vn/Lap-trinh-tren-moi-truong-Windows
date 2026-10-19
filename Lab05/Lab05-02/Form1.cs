using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Lab05_02
{
    public partial class Form1 : Form
    {
        // Lưu đường dẫn file hiện tại
        private string currentFile = "";

        public Form1()
        {
            InitializeComponent();

            // Load danh sách Font
            LoadFonts();

            // Load danh sách Size
            LoadSizes();

            // Giá trị mặc định
            cmbFonts.Text = "Tahoma";
            cmbSize.Text = "14";

            richText.Font = new Font("Tahoma", 14);

            // Cập nhật số từ
            UpdateWordCount();
        }

        // =========================================================
        // LOAD FONT
        // =========================================================

        private void LoadFonts()
        {
            cmbFonts.Items.Clear();

            InstalledFontCollection fonts =
                new InstalledFontCollection();

            foreach (FontFamily font in fonts.Families)
            {
                cmbFonts.Items.Add(font.Name);
            }
        }

        // =========================================================
        // LOAD SIZE
        // =========================================================

        private void LoadSizes()
        {
            cmbSize.Items.Clear();

            int[] sizes =
            {
                8, 9, 10, 11, 12, 14, 16,
                18, 20, 22, 24, 26, 28,
                36, 48, 72
            };

            foreach (int size in sizes)
            {
                cmbSize.Items.Add(size.ToString());
            }
        }

        // =========================================================
        // TẠO VĂN BẢN MỚI
        // =========================================================

        private void NewDocument()
        {
            richText.Clear();

            currentFile = "";

            // Font mặc định
            richText.Font = new Font("Tahoma", 14);
            richText.ForeColor = Color.Black;

            cmbFonts.Text = "Tahoma";
            cmbSize.Text = "14";

            UpdateWordCount();

            richText.Focus();
        }

        // =========================================================
        // MỞ FILE
        // =========================================================

        private void OpenDocument()
        {
            openFileDialog1.Title = "Mở tập tin";

            openFileDialog1.Filter =
                "Rich Text Format (*.rtf)|*.rtf|" +
                "Text files (*.txt)|*.txt";

            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                string fileName = openFileDialog1.FileName;

                string extension =
                    Path.GetExtension(fileName).ToLower();

                if (extension == ".rtf")
                {
                    richText.LoadFile(
                        fileName,
                        RichTextBoxStreamType.RichText
                    );
                }
                else
                {
                    richText.LoadFile(
                        fileName,
                        RichTextBoxStreamType.PlainText
                    );
                }

                currentFile = fileName;

                UpdateWordCount();

                MessageBox.Show(
                    "Mở tập tin thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể mở tập tin!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LƯU FILE
        // =========================================================

        private void SaveDocument()
        {
            // Nếu chưa từng lưu
            if (string.IsNullOrEmpty(currentFile))
            {
                saveFileDialog1.Title = "Lưu văn bản";

                saveFileDialog1.Filter =
                    "Rich Text Format (*.rtf)|*.rtf";

                saveFileDialog1.DefaultExt = "rtf";
                saveFileDialog1.AddExtension = true;

                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                currentFile = saveFileDialog1.FileName;
            }

            try
            {
                richText.SaveFile(
                    currentFile,
                    RichTextBoxStreamType.RichText
                );

                MessageBox.Show(
                    "Lưu văn bản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể lưu tập tin!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // FONT DIALOG
        // =========================================================

        private void menuFont_Click(
            object sender,
            EventArgs e)
        {
            using (FontDialog fontDlg = new FontDialog())
            {
                fontDlg.ShowColor = true;
                fontDlg.ShowApply = true;
                fontDlg.ShowEffects = true;
                fontDlg.ShowHelp = true;

                Font currentFont =
                    richText.SelectionFont ?? richText.Font;

                fontDlg.Font = currentFont;
                fontDlg.Color = richText.SelectionColor;

                if (fontDlg.ShowDialog() != DialogResult.Cancel)
                {
                    if (richText.SelectionLength > 0)
                    {
                        richText.SelectionFont = fontDlg.Font;
                        richText.SelectionColor = fontDlg.Color;
                    }
                    else
                    {
                        richText.Font = fontDlg.Font;
                        richText.ForeColor = fontDlg.Color;
                    }

                    cmbFonts.Text =
                        fontDlg.Font.FontFamily.Name;

                    cmbSize.Text =
                        ((int)fontDlg.Font.Size).ToString();
                }
            }
        }

        // =========================================================
        // CHỌN FONT
        // =========================================================

        private void cmbFonts_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbFonts.SelectedItem == null)
            {
                return;
            }

            string fontName =
                Convert.ToString(cmbFonts.SelectedItem) ?? "";

            if (string.IsNullOrEmpty(fontName))
            {
                return;
            }

            Font currentFont =
                richText.SelectionFont ?? richText.Font;

            try
            {
                Font newFont = new Font(
                    fontName,
                    currentFont.Size,
                    currentFont.Style
                );

                if (richText.SelectionLength > 0)
                {
                    richText.SelectionFont = newFont;
                }
                else
                {
                    richText.Font = newFont;
                }
            }
            catch
            {
                // Nếu Font không hợp lệ thì bỏ qua
            }
        }

        // =========================================================
        // CHỌN SIZE
        // =========================================================

        private void cmbSize_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbSize.SelectedItem == null)
            {
                return;
            }

            string sizeText =
                Convert.ToString(cmbSize.SelectedItem) ?? "";

            if (!float.TryParse(sizeText, out float size))
            {
                return;
            }

            Font currentFont =
                richText.SelectionFont ?? richText.Font;

            Font newFont = new Font(
                currentFont.FontFamily,
                size,
                currentFont.Style
            );

            if (richText.SelectionLength > 0)
            {
                richText.SelectionFont = newFont;
            }
            else
            {
                richText.Font = newFont;
            }
        }

        // =========================================================
        // BOLD
        // =========================================================

        private void btnBold_Click(
            object sender,
            EventArgs e)
        {
            if (richText.SelectionLength == 0)
            {
                return;
            }

            Font? currentFont =
                richText.SelectionFont;

            if (currentFont == null)
            {
                return;
            }

            FontStyle newStyle;

            if (currentFont.Bold)
            {
                newStyle =
                    currentFont.Style & ~FontStyle.Bold;
            }
            else
            {
                newStyle =
                    currentFont.Style | FontStyle.Bold;
            }

            richText.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newStyle
            );
        }

        // =========================================================
        // ITALIC
        // =========================================================

        private void btnItalic_Click(
            object sender,
            EventArgs e)
        {
            if (richText.SelectionLength == 0)
            {
                return;
            }

            Font? currentFont =
                richText.SelectionFont;

            if (currentFont == null)
            {
                return;
            }

            FontStyle newStyle;

            if (currentFont.Italic)
            {
                newStyle =
                    currentFont.Style & ~FontStyle.Italic;
            }
            else
            {
                newStyle =
                    currentFont.Style | FontStyle.Italic;
            }

            richText.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newStyle
            );
        }

        // =========================================================
        // UNDERLINE
        // =========================================================

        private void btnUnderline_Click(
            object sender,
            EventArgs e)
        {
            if (richText.SelectionLength == 0)
            {
                return;
            }

            Font? currentFont =
                richText.SelectionFont;

            if (currentFont == null)
            {
                return;
            }

            FontStyle newStyle;

            if (currentFont.Underline)
            {
                newStyle =
                    currentFont.Style & ~FontStyle.Underline;
            }
            else
            {
                newStyle =
                    currentFont.Style | FontStyle.Underline;
            }

            richText.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newStyle
            );
        }

        // =========================================================
        // ĐẾM SỐ TỪ
        // =========================================================

        private void UpdateWordCount()
        {
            string text =
                richText.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                lblSoTu.Text = "Tổng số từ: 0";
                return;
            }

            string[] words =
                text.Split(
                    new char[]
                    {
                        ' ',
                        '\n',
                        '\r',
                        '\t'
                    },
                    StringSplitOptions.RemoveEmptyEntries
                );

            lblSoTu.Text =
                "Tổng số từ: " + words.Length;
        }

        // =========================================================
        // RICHTEXTBOX TEXT CHANGED
        // =========================================================

        private void richText_TextChanged(
            object sender,
            EventArgs e)
        {
            UpdateWordCount();
        }

        // =========================================================
        // MENU - TẠO MỚI
        // =========================================================

        private void menuTaoMoi_Click(
            object sender,
            EventArgs e)
        {
            NewDocument();
        }

        // =========================================================
        // MENU - MỞ
        // =========================================================

        private void menuMo_Click(
            object sender,
            EventArgs e)
        {
            OpenDocument();
        }

        // =========================================================
        // MENU - LƯU
        // =========================================================

        private void menuLuu_Click(
            object sender,
            EventArgs e)
        {
            SaveDocument();
        }

        // =========================================================
        // MENU - THOÁT
        // =========================================================

        private void menuThoat_Click(
            object sender,
            EventArgs e)
        {
            Application.Exit();
        }

        // =========================================================
        // TOOLBAR - NEW
        // =========================================================

        private void btnNew_Click(
            object sender,
            EventArgs e)
        {
            NewDocument();
        }

        // =========================================================
        // TOOLBAR - OPEN
        // =========================================================

        private void btnOpen_Click(
            object sender,
            EventArgs e)
        {
            OpenDocument();
        }

        // =========================================================
        // TOOLBAR - SAVE
        // =========================================================

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            SaveDocument();
        }
    }
}