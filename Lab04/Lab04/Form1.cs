using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        // Danh sách nhân viên
        BindingList<NhanVien> danhSachNhanVien =
            new BindingList<NhanVien>();

        // ==============================
        // FORM1
        // ==============================
        public Form1()
        {
            InitializeComponent();

            // ==============================
            // CẤU HÌNH DATAGRIDVIEW
            // ==============================

            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.DataSource =
                danhSachNhanVien;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            dataGridView1.ReadOnly = true;

            // ==============================
            // KẾT NỐI EVENT CHO CÁC NÚT
            // ==============================

            btnThem.Click += btnThem_Click;

            btnSua.Click += btnSua_Click;

            btnXoa.Click += btnXoa_Click;

            btnDong.Click += btnDong_Click;

            // Double click dòng để sửa
            dataGridView1.CellDoubleClick +=
                dataGridView1_CellDoubleClick;
        }

        // ==============================
        // THÊM NHÂN VIÊN
        // ==============================
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Mở Form2
            Form2 f = new Form2();

            // Hiển thị Form2
            if (f.ShowDialog() == DialogResult.OK)
            {
                // Thêm nhân viên vào danh sách
                danhSachNhanVien.Add(f.NhanVien);
            }
        }

        // ==============================
        // SỬA NHÂN VIÊN
        // ==============================
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn dòng chưa
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn nhân viên cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Lấy nhân viên đang chọn
            NhanVien nv =
                dataGridView1.CurrentRow.DataBoundItem
                as NhanVien;

            if (nv == null)
            {
                return;
            }

            // Mở Form2 và truyền nhân viên vào
            Form2 f = new Form2(nv);

            // Nếu người dùng bấm Đồng ý
            if (f.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật dữ liệu
                nv.MSNV = f.NhanVien.MSNV;

                nv.TenNV = f.NhanVien.TenNV;

                nv.LuongCB = f.NhanVien.LuongCB;

                // Cập nhật DataGridView
                dataGridView1.Refresh();
            }
        }

        // ==============================
        // XÓA NHÂN VIÊN
        // ==============================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn dòng chưa
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn nhân viên cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Lấy nhân viên đang chọn
            NhanVien nv =
                dataGridView1.CurrentRow.DataBoundItem
                as NhanVien;

            if (nv == null)
            {
                return;
            }

            // Hỏi xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa nhân viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu chọn Yes
            if (result == DialogResult.Yes)
            {
                danhSachNhanVien.Remove(nv);
            }
        }

        // ==============================
        // ĐÓNG FORM1
        // ==============================
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ==============================
        // DOUBLE CLICK DATAGRIDVIEW
        // ==============================
        private void dataGridView1_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            // Không xử lý khi click header
            if (e.RowIndex < 0)
            {
                return;
            }

            // Lấy nhân viên
            NhanVien nv =
                dataGridView1.Rows[e.RowIndex]
                .DataBoundItem as NhanVien;

            if (nv == null)
            {
                return;
            }

            // Mở Form2 để sửa
            Form2 f = new Form2(nv);

            if (f.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật
                nv.MSNV = f.NhanVien.MSNV;

                nv.TenNV = f.NhanVien.TenNV;

                nv.LuongCB = f.NhanVien.LuongCB;

                // Refresh
                dataGridView1.Refresh();
            }
        }
    }
}