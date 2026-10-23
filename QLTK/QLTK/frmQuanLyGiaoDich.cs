using QLTK.BLL;
using System.Diagnostics;
using System.Globalization;

namespace QLTK
{
    public partial class frmQuanLyGiaoDich : Form
    {
        private readonly TaiKhoanBLL _taiKhoanBLL = new();
        private readonly GiaoDichBLL _giaoDichBLL = new();

        public frmQuanLyGiaoDich()
        {
            InitializeComponent();
            Text = "Quản lý giao dịch tài khoản";
            StartPosition = FormStartPosition.CenterScreen;

            // Chỉ cấu hình hành vi; vị trí và kích thước chỉnh trong tab Design.
            cboSTK.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiGD.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNoiDung.Multiline = true;
            txtNoiDung.ScrollBars = ScrollBars.Vertical;
            dgvGiaoDich.ReadOnly = true;
            dgvGiaoDich.AllowUserToAddRows = false;
            dgvGiaoDich.MultiSelect = false;
            dgvGiaoDich.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGiaoDich.RowHeadersVisible = false;
            dgvGiaoDich.AutoGenerateColumns = false;
            dgvGiaoDich.Columns.Clear();
            dgvGiaoDich.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", FillWeight = 12 });
            dgvGiaoDich.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LoaiGD", HeaderText = "Loại GD", FillWeight = 20 });
            dgvGiaoDich.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoTien", HeaderText = "Số tiền", FillWeight = 18, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
            dgvGiaoDich.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NoiDung", HeaderText = "Nội dung", FillWeight = 50 });

            btnThemMoi.Click += btnThemMoi_Click;
            dgvGiaoDich.CellClick += dgvGiaoDich_CellClick;
            cácGiaoDịchGửiTiềnToolStripMenuItem.Click += menuNhanTien_Click;
            sốDưCuốiKỳToolStripMenuItem.Click += menuSoDu_Click;
            xuấtBáoCáoToolStripMenuItem.Click += menuSaoKe_Click;
            xuấtExcelToolStripMenuItem.Click += menuExcel_Click;
            Load += frmQuanLyGiaoDich_Load;
        }

        private void frmQuanLyGiaoDich_Load(object? sender, EventArgs e)
        {
            try
            {
                cboSTK.DataSource = _taiKhoanBLL.LayTatCa();
                cboSTK.DisplayMember = nameof(TaiKhoanDto.STK);
                cboSTK.ValueMember = nameof(TaiKhoanDto.STK);
                cboLoaiGD.Items.Clear();
                cboLoaiGD.Items.AddRange(new object[] { "Nhận tiền", "Rút tiền" });
                if (cboSTK.Items.Count > 0) cboSTK.SelectedIndex = 0;
                if (cboLoaiGD.Items.Count > 0) cboLoaiGD.SelectedIndex = 0;
                NapGiaoDich(_giaoDichBLL.LayTatCa());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu. Kiểm tra chuỗi kết nối và database.\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NapGiaoDich(List<GiaoDichDto> danhSach)
        {
            dgvGiaoDich.DataSource = null;
            dgvGiaoDich.DataSource = danhSach;
        }

        private void dgvGiaoDich_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvGiaoDich.Rows[e.RowIndex].DataBoundItem is not GiaoDichDto gd) return;
            cboSTK.SelectedValue = gd.STK;
            cboLoaiGD.SelectedItem = gd.LoaiGD;
            txtSoTien.Text = gd.SoTien.ToString(CultureInfo.InvariantCulture);
            txtNoiDung.Text = gd.NoiDung;
        }

        private void btnThemMoi_Click(object? sender, EventArgs e)
        {
            if (cboSTK.SelectedValue == null || cboLoaiGD.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn số tài khoản và loại giao dịch!");
                return;
            }
            if (!int.TryParse(txtSoTien.Text.Trim(), out int soTien) || soTien < 1 || soTien > 100_000_000)
            {
                MessageBox.Show("Vui lòng nhập số tiền từ 1-100000000!");
                txtSoTien.Focus();
                return;
            }
            try
            {
                _giaoDichBLL.Them(cboSTK.SelectedValue.ToString()!, cboLoaiGD.SelectedItem.ToString()!, soTien, txtNoiDung.Text);
                MessageBox.Show("Thêm mới giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                NapGiaoDich(_giaoDichBLL.LayTatCa());
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu giao dịch: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LamMoi()
        {
            if (cboSTK.Items.Count > 0) cboSTK.SelectedIndex = 0;
            if (cboLoaiGD.Items.Count > 0) cboLoaiGD.SelectedIndex = 0;
            txtSoTien.Clear();
            txtNoiDung.Clear();
            txtSoTien.Focus();
        }

        private void menuNhanTien_Click(object? sender, EventArgs e)
        {
            try { NapGiaoDich(_giaoDichBLL.LayGiaoDichNhanTien()); }
            catch (Exception ex) { MessageBox.Show("Lỗi tải giao dịch: " + ex.Message); }
        }

        private void menuSoDu_Click(object? sender, EventArgs e)
        {
            try
            {
                var noiDung = string.Join(Environment.NewLine,
                    _taiKhoanBLL.LaySoDuCuoiKy().Select((tk, i) =>
                        $"{i + 1}. STK: {tk.STK} — Số dư: {tk.SoDuCuoiKy:N0}"));
                MessageBox.Show(noiDung, "Số dư cuối kỳ");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tính số dư: " + ex.Message); }
        }

        private void menuSaoKe_Click(object? sender, EventArgs e)
        {
            using var form = new frmSaoKe(_taiKhoanBLL, _giaoDichBLL);
            form.ShowDialog(this);
        }

        private void menuExcel_Click(object? sender, EventArgs e)
        {
            if (cboSTK.SelectedValue == null) return;
            string stk = cboSTK.SelectedValue.ToString()!;
            var taiKhoan = _taiKhoanBLL.LayTatCa().FirstOrDefault(tk => tk.STK == stk);
            if (taiKhoan == null) return;
            using var dialog = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"SaoKe_{stk}.xlsx",
                Title = "Lưu sao kê Excel"
            };
            if (dialog.ShowDialog(this) != DialogResult.OK) return;
            try
            {
                new BaoCaoExcel().Xuat(dialog.FileName, taiKhoan, _giaoDichBLL.LayTheoTaiKhoan(stk));
                var answer = MessageBox.Show("Xuất file Excel thành công!\nBạn có muốn mở file không?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (answer == DialogResult.Yes)
                    Process.Start(new ProcessStartInfo(dialog.FileName) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xuất được Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}