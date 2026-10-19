using System;
using System.Collections.Generic;
using System.Text;

namespace EFC
{
    public class Student
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{Id} - {FullName} - {Grade}";
        }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; } = null!;
    }
}
