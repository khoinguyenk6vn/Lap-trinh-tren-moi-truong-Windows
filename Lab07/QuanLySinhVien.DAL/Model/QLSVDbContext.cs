using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.DAL.Model
{
    public class QLSVDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.\\SQLEXPRESS;" +
                "Database=QLSV;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;"
            );
        }

    }
}
