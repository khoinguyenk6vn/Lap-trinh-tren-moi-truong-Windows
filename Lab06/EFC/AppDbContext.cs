using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFC
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            // Sửa lại Server cho đúng máy của bạn trước khi chạy thử
            optionsBuilder.UseSqlServer(
            "Server=.\\SQLEXPRESS;" +
            "Database=QuanLySinhVien;" +
            "Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
        public async Task<List<Student>> LayDanhSachAsync()
        {
            using (var context = new AppDbContext())
            {
                return await context.Students.ToListAsync();
            }
        }
    }
}
