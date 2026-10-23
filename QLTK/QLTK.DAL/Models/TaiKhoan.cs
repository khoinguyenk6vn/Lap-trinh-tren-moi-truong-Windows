using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QLTK.DAL.Models
{
    public class TaiKhoan
    {
        [Key, StringLength(10)]
        public string STK { get; set; } = null!;

        [Required, StringLength(150)]
        public string TenNH { get; set; } = null!;

        [Required]
        public decimal SoDuDauKy { get; set; }

        public ICollection<GiaoDich> GiaoDiches { get; set; }
            = new List<GiaoDich>();
    }
}
