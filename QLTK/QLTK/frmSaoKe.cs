using QLTK.BLL;

namespace QLTK
{
    public partial class frmSaoKe : Form
    {
        private readonly TaiKhoanBLL _taiKhoanBLL;
        private readonly GiaoDichBLL _giaoDichBLL;

        public frmSaoKe(TaiKhoanBLL taiKhoanBLL, GiaoDichBLL giaoDichBLL)
        {
            InitializeComponent();
            _taiKhoanBLL = taiKhoanBLL;
            _giaoDichBLL = giaoDichBLL;
            Text = "Sao kê tài khoản";
            StartPosition = FormStartPosition.CenterParent;
            cboSTK.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvSaoKe.ReadOnly = true;
            dgvSaoKe.AllowUserToAddRows = false;
            dgvSaoKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnXem.Click += btnXem_Click;
            Load += frmSaoKe_Load;
        }

        private void frmSaoKe_Load(object? sender, EventArgs e)
        {
            try
            {
                cboSTK.DataSource = _taiKhoanBLL.LayTatCa();
                cboSTK.DisplayMember = nameof(TaiKhoanDto.STK);
                cboSTK.ValueMember = nameof(TaiKhoanDto.STK);
                if (cboSTK.Items.Count > 0)
                {
                    cboSTK.SelectedIndex = 0;
                    HienThiSaoKe();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách tài khoản: " + ex.Message);
            }
        }

        private void btnXem_Click(object? sender, EventArgs e) => HienThiSaoKe();

        private void HienThiSaoKe()
        {
            if (cboSTK.SelectedValue == null) return;
            string stk = cboSTK.SelectedValue.ToString()!;
            var taiKhoan = _taiKhoanBLL.LayTatCa().FirstOrDefault(tk => tk.STK == stk);
            if (taiKhoan == null) return;

            lblNganHang.Text = taiKhoan.TenNH;
            lblThongTin.Text = $"Số tài khoản: {taiKhoan.STK}    |    Số dư cuối kỳ: {taiKhoan.SoDuCuoiKy:N0}";
            dgvSaoKe.DataSource = _giaoDichBLL.LayTheoTaiKhoan(stk).Select(gd => new
            {
                gd.Id,
                gd.LoaiGD,
                SoTien = gd.SoTienGoc,
                gd.NoiDung
            }).ToList();
        }
    }
}