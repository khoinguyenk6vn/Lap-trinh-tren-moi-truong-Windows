using System;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form2 : Form
    {
        public NhanVien NhanVien { get; set; }

        // ==============================
        // FORM2 - THÊM NHÂN VIÊN
        // ==============================
        public Form2()
        {
            InitializeComponent();

            // Kết nối sự kiện nút
            btnDongY.Click += btnDongY_Click;
            btnBoQua.Click += btnBoQua_Click;

            // Tạo nhân viên mới
            NhanVien = new NhanVien();
        }

        // ==============================
        // FORM2 - SỬA NHÂN VIÊN
        // ==============================
        public Form2(NhanVien nv)
        {
            InitializeComponent();

            // Kết nối sự kiện nút
            btnDongY.Click += btnDongY_Click;
            btnBoQua.Click += btnBoQua_Click;

            // Tạo bản sao để chỉnh sửa
            NhanVien = new NhanVien(
                nv.MSNV,
                nv.TenNV,
                nv.LuongCB
            );

            // Hiển thị dữ liệu cũ lên Form2
            txtMSNV.Text = nv.MSNV;
            txtTenNV.Text = nv.TenNV;
            txtLuongCB.Text = nv.LuongCB.ToString();
        }

        // ==============================
        // NÚT ĐỒNG Ý
        // ==============================
        private void btnDongY_Click(object sender, EventArgs e)
        {
            // Kiểm tra MSNV
            if (string.IsNullOrWhiteSpace(txtMSNV.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã số nhân viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtMSNV.Focus();
                return;
            }

            // Kiểm tra tên nhân viên
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên nhân viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTenNV.Focus();
                return;
            }

            // Kiểm tra lương
            decimal luong;

            if (!decimal.TryParse(txtLuongCB.Text, out luong))
            {
                MessageBox.Show(
                    "Lương cơ bản phải là số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtLuongCB.Focus();
                return;
            }

            // Không cho lương âm
            if (luong < 0)
            {
                MessageBox.Show(
                    "Lương cơ bản không được âm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtLuongCB.Focus();
                return;
            }

            // Gán dữ liệu
            NhanVien.MSNV = txtMSNV.Text.Trim();
            NhanVien.TenNV = txtTenNV.Text.Trim();
            NhanVien.LuongCB = luong;

            // Trả kết quả OK về Form1
            DialogResult = DialogResult.OK;

            // Đóng Form2
            Close();
        }

        // ==============================
        // NÚT BỎ QUA
        // ==============================
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}