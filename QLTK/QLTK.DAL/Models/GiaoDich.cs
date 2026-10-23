using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QLTK.DAL.Models
{
    public class GiaoDich
    {
        public int Id { get; set; }  // Khóa chính, tự tăng

        [Required]
        public int SoTien { get; set; }

        [StringLength(255)]
        public string? NoiDung { get; set; }

        [Required, StringLength(10)]
        public string STK { get; set; } = null!;

        public TaiKhoan TaiKhoan { get; set; } = null!;
    }
}
