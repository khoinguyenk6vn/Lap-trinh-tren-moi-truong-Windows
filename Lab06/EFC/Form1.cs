
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace EFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // FORM LOAD
        private async void Form1_Load(object sender, EventArgs e)
        {
            lblTrangThai.Text = "Đang tải dữ liệu...";
            await TaiDanhSach();
        }

        // READ - Tải danh sách sinh viên
        private async Task TaiDanhSach()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    List<Student> danhSach =
                        await context.LayDanhSachAsync();

                    dgvSinhVien.DataSource = null;
                    dgvSinhVien.DataSource = danhSach;

                    lblTrangThai.Text =
                        $"Đã tải {danhSach.Count} sinh viên.";
                    lblTrangThai.ForeColor =
                        System.Drawing.Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor =
                    System.Drawing.Color.Red;
            }
        }

        // NÚT TẢI LẠI
        private async void btnTaiLai_Click(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        // CHỌN DÒNG TRÊN DATAGRIDVIEW
        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is Student sv)
            {
                txtHoTen.Text = sv.FullName;
                txtDiem.Text = sv.Grade.ToString();
            }
        }

        // CREATE - THÊM SINH VIÊN
        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            if (!double.TryParse(txtDiem.Text, out double diem)
                || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là số từ 0 đến 10!");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    context.Students.Add(new Student
                    {
                        FullName = txtHoTen.Text.Trim(),
                        Grade = diem
                    });

                    await context.SaveChangesAsync();
                }

                txtHoTen.Clear();
                txtDiem.Clear();

                lblTrangThai.Text = "Đã thêm sinh viên mới!";
                lblTrangThai.ForeColor =
                    System.Drawing.Color.DarkGreen;

                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor =
                    System.Drawing.Color.Red;
            }
        }

        // UPDATE - SỬA SINH VIÊN
        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is not Student svChon)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            if (!double.TryParse(txtDiem.Text, out double diem)
                || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là số từ 0 đến 10!");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    Student sv = await context.Students
                        .FindAsync(svChon.Id);

                    if (sv == null)
                    {
                        MessageBox.Show("Không tìm thấy sinh viên!");
                        return;
                    }

                    sv.FullName = txtHoTen.Text.Trim();
                    sv.Grade = diem;

                    await context.SaveChangesAsync();
                }

                lblTrangThai.Text = "Đã cập nhật thông tin!";
                lblTrangThai.ForeColor =
                    System.Drawing.Color.DarkGreen;

                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor =
                    System.Drawing.Color.Red;
            }
        }

        // DELETE - XÓA SINH VIÊN
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is not Student svChon)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                $"Bạn có chắc muốn xóa \"{svChon.FullName}\"?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                using (var context = new AppDbContext())
                {
                    Student sv = await context.Students
                        .FindAsync(svChon.Id);

                    if (sv != null)
                    {
                        context.Students.Remove(sv);
                        await context.SaveChangesAsync();
                    }
                }

                txtHoTen.Clear();
                txtDiem.Clear();

                lblTrangThai.Text = "Đã xóa sinh viên!";
                lblTrangThai.ForeColor =
                    System.Drawing.Color.DarkGreen;

                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor =
                    System.Drawing.Color.Red;
            }
        }

        // LINQ - LỌC SINH VIÊN ĐẠT
        private async void btnLocDat_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    List<Student> ketQua = await context.Students
                        .AsNoTracking()
                        .Where(sv => sv.Grade >= 5)
                        .OrderByDescending(sv => sv.Grade)
                        .ToListAsync();

                    dgvSinhVien.DataSource = null;
                    dgvSinhVien.DataSource = ketQua;

                    lblTrangThai.Text =
                        $"Tìm thấy {ketQua.Count} sinh viên đạt (>= 5).";

                    lblTrangThai.ForeColor =
                        System.Drawing.Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor =
                    System.Drawing.Color.Red;
            }
        }

        // NÚT BUTTON1 NẾU BẠN ĐANG DÙNG NÚT NÀY ĐỂ TẢI DANH SÁCH
        private async void button1_Click(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }
    }
}