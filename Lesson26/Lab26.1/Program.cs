namespace Lab26._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
        {
            new Student(1, "Khanh1", 20),
            new Student(2, "Khanh2", 22),
            new Student(3, "Khanh3", 18),
            new Student(4, "Khanh4", 21),
            new Student(5, "Khanh5", 19),
            new Student(6, "Khanh6", 23),
            new Student(7, "Khanh7", 20),
            new Student(8, "Khanh8", 17),
            new Student(9, "Khanh9", 25),
            new Student(10, "Khanh10", 24)
        };

            // Tìm student có tuổi nhỏ nhất
            Student minAgeStudent = students.OrderBy(s => s.Age).FirstOrDefault();
            Console.WriteLine("Sinh viên có tuổi nhỏ nhất:");
            Console.WriteLine(minAgeStudent);

            // Sắp xếp mảng tăng dần theo tuổi sinh viên
            var sortedStudents = students.OrderBy(s => s.Age).ToArray();
            Console.WriteLine("\nDanh sách sinh viên sau khi sắp xếp theo tuổi tăng dần:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            // Tìm student có tuổi lớn nhất
            Student maxAgeStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine("\nSinh viên có tuổi lớn nhất:");
            Console.WriteLine(maxAgeStudent);
        }
    }
}
