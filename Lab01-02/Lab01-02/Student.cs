using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_02
{
    class Student
    {
        // 1. Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // 2. Constructor
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        // 3. Hiển thị thông tin
        public void Show()
        {
            Console.WriteLine(
                $"Id: {Id} | Tên: {Name} | Tuổi: {Age}"
            );
        }
    }
}
