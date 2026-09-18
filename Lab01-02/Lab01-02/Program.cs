using Lab01_02;

class Program
{
    static void Main(string[] args)
    {
        // Tạo danh sách học sinh
        List<Student> studentList = new List<Student>();

        // Thêm ít nhất 5 học sinh
        studentList.Add(new Student(1, "An", 15));
        studentList.Add(new Student(2, "Bình", 17));
        studentList.Add(new Student(3, "Anh", 18));
        studentList.Add(new Student(4, "Cường", 14));
        studentList.Add(new Student(5, "A Huy", 16));

        // a. In danh sách toàn bộ học sinh
        Console.WriteLine("=== a. DANH SÁCH TẤT CẢ HỌC SINH ===");

        foreach (Student student in studentList)
        {
            student.Show();
        }

        // b. Tìm học sinh có tuổi từ 15 đến 18
        Console.WriteLine("\n=== b. HỌC SINH TỪ 15 ĐẾN 18 TUỔI ===");

        var students15To18 = studentList
            .Where(s => s.Age >= 15 && s.Age <= 18);

        foreach (Student student in students15To18)
        {
            student.Show();
        }

        // c. Tìm học sinh có tên bắt đầu bằng chữ "A"
        Console.WriteLine("\n=== c. HỌC SINH CÓ TÊN BẮT ĐẦU BẰNG 'A' ===");

        var studentsStartWithA = studentList
            .Where(s => s.Name.StartsWith("A"));

        foreach (Student student in studentsStartWithA)
        {
            student.Show();
        }

        // d. Tính tổng tuổi của tất cả học sinh
        Console.WriteLine("\n=== d. TỔNG TUỔI CỦA TẤT CẢ HỌC SINH ===");

        int totalAge = studentList.Sum(s => s.Age);

        Console.WriteLine($"Tổng tuổi: {totalAge}");

        // e. Tìm học sinh có tuổi lớn nhất
        Console.WriteLine("\n=== e. HỌC SINH CÓ TUỔI LỚN NHẤT ===");

        int maxAge = studentList.Max(s => s.Age);

        var oldestStudents = studentList
            .Where(s => s.Age == maxAge);

        foreach (Student student in oldestStudents)
        {
            student.Show();
        }

        // f. Sắp xếp học sinh theo tuổi tăng dần
        Console.WriteLine("\n=== f. DANH SÁCH SAU KHI SẮP XẾP TUỔI TĂNG DẦN ===");

        var sortedStudents = studentList
            .OrderBy(s => s.Age);

        foreach (Student student in sortedStudents)
        {
            student.Show();
        }

        Console.ReadKey();
    }
}