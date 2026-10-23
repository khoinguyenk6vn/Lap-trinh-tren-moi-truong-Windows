using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLySinhVien.DAL.Model
{
    public class SinhVienDAL
    {
        public List<Student> LayDanhSach()
        {
            using var db = new QLSVDbContext();
            // Lấy danh sách sinh viên, sắp xếp theo FullName cho dễ nhìn
            return db.Students.OrderBy(s => s.FullName).ToList();
        }

        public Student? LayTheoId(int id)
        {
            using var db = new QLSVDbContext();
            // FirstOrDefault theo Id
            return db.Students.FirstOrDefault(s => s.Id == id);
        }

        public bool KiemTraTrungMa(string maSV)
        {
            using var db = new QLSVDbContext();
            // Vì class Student mới không có MaSV, mặc định trả về false hoặc có thể kiểm tra trùng FullName nếu cần
            return false;
        }

        public void ThemMoi(Student sv)
        {
            using var db = new QLSVDbContext();
            // Add() rồi gọi SaveChanges() để ghi thật xuống database
            db.Students.Add(sv);
            db.SaveChanges();
        }

        public void CapNhat(Student sv) // Đã đồng bộ kiểu dữ liệu tham số là Student theo model thực tế
        {
            using var db = new QLSVDbContext();
            // Bước 1: Tìm lại bản ghi GỐC trong database theo sv.Id
            Student? svTrongDb = db.Students.Find(sv.Id);
            if (svTrongDb == null)
            {
                throw new Exception("Không tìm thấy sinh viên cần cập nhật.");
            }

            // Bước 2: Gán lại từng thuộc tính mới vào bản ghi gốc
            svTrongDb.FullName = sv.FullName;
            svTrongDb.Grade = sv.Grade;

            // Bước 3: Lưu thay đổi
            db.SaveChanges();
        }

        public void Xoa(int id)
        {
            using var db = new QLSVDbContext();
            // Tìm trước, kiểm tra null, rồi mới Remove + Save
            var sv = db.Students.Find(id);
            if (sv != null)
            {
                db.Students.Remove(sv);
                db.SaveChanges();
            }
        }

        public List<Student> TimKiem(string? tuKhoaVanBan, int? khoaId, double diemTu, double diemDen, bool baoGomChuaCoDiem)
        {
            using var db = new QLSVDbContext();

            // Bước 1: Bắt đầu truy vấn với AsQueryable()
            var truyVan = db.Students.AsQueryable();

            // Bước 2: Nếu có nhập từ khóa -> lọc theo FullName (không phân biệt hoa/thường)
            if (!string.IsNullOrWhiteSpace(tuKhoaVanBan))
            {
                string tuKhoa = tuKhoaVanBan.Trim().ToLower();
                truyVan = truyVan.Where(s => s.FullName.ToLower().Contains(tuKhoa));
            }

            // Bước 3: Lọc theo khoảng điểm Grade
            var danhSach = truyVan.ToList();
            return danhSach.Where(s => s.Grade >= diemTu && s.Grade <= diemDen).ToList();
        }
    }
}