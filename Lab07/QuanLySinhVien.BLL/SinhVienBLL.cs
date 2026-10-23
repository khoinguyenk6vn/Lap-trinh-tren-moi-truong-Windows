using QuanLySinhVien.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.BLL
{
    public class SinhVienBLL
    {
        private readonly SinhVienDAL sinhVienDAL = new SinhVienDAL();

        public List<Student> LayDanhSach()
        {
            return sinhVienDAL.LayDanhSach();
        }

        public Student? LayTheoId(int id)
        {
            return sinhVienDAL.LayTheoId(id);
        }

        /// Hàm dùng chung cho ThemMoi() và CapNhat() — validate mọi điều kiện,
        /// đồng thời "xuất" ra giá trị diemTB đã parse xong (qua tham số out).
        private void ValidateDuLieu(string maSV, string hoTen, int khoaId, string? diemTBText, out double? diemTB)
        {
            // Kiểm tra họ tên (FullName) không được trống
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                throw new Exception("Họ tên sinh viên không được để trống.");
            }

            diemTB = null;
            if (!string.IsNullOrWhiteSpace(diemTBText))
            {
                // 4a. Parse có thành công không? (dùng TryParse, không dùng Parse)
                if (!double.TryParse(diemTBText, out double parsedDiem))
                {
                    throw new Exception("Điểm phải là một số hợp lệ.");
                }

                // 4b. Nếu parse được, có nằm trong khoảng 0-10 không?
                if (parsedDiem < 0 || parsedDiem > 10)
                {
                    throw new Exception("Điểm phải nằm trong khoảng từ 0 đến 10.");
                }

                // 4c. Nếu qua hết 2 bước trên, gán vào diemTB
                diemTB = parsedDiem;
            }
        }

        public void ThemMoi(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh, int khoaId, string? diemTBText)
        {
            // Bước 1: gọi ValidateDuLieu() — nếu có lỗi, hàm này tự throw, code dừng lại luôn tại đây
            ValidateDuLieu(maSV, hoTen, khoaId, diemTBText, out double? diemTB);

            // Bước 2: Tạo object Student mới và gọi sinhVienDAL.ThemMoi()
            Student sv = new Student
            {
                FullName = hoTen.Trim(),
                Grade = diemTB ?? 0.0
            };

            sinhVienDAL.ThemMoi(sv);
        }

        public void CapNhat(int id, string maSVHienTai, string hoTen, DateTime ngaySinh, string gioiTinh, int khoaId, string? diemTBText)
        {
            // Validate dữ liệu đầu vào
            ValidateDuLieu(maSVHienTai, hoTen, khoaId, diemTBText, out double? diemTB);

            // Tạo object Student với Id cần cập nhật
            Student sv = new Student
            {
                Id = id,
                FullName = hoTen.Trim(),
                Grade = diemTB ?? 0.0
            };

            sinhVienDAL.CapNhat(sv);
        }

        public void Xoa(int id)
        {
            sinhVienDAL.Xoa(id);
        }

        public List<Student> TimKiem(string? tuKhoaVanBan, int? khoaId, double diemTu, double diemDen, bool baoGomChuaCoDiem)
        {
            // Bước 1: kiểm tra tính hợp lý của khoảng điểm (diemTu không được lớn hơn diemDen)
            if (diemTu > diemDen)
            {
                throw new Exception("Điểm bắt đầu không được lớn hơn điểm kết thúc.");
            }

            // Bước 2: gọi DAL thực hiện tìm kiếm
            return sinhVienDAL.TimKiem(tuKhoaVanBan, khoaId, diemTu, diemDen, baoGomChuaCoDiem);
        }
    }
}