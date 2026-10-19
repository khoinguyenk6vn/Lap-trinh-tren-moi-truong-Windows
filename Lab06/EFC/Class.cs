using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFC
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        [Required]
        [StringLength(100)]
        public string ClassName { get; set; } = string.Empty;

        // Một lớp có nhiều sinh viên
        public virtual ICollection<Student> Students { get; set; }
            = new List<Student>();
    }
}