namespace Bai07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student1 = new Student(1, "Alice", 8.5, 9);
                Console.WriteLine($"{student1.Name} có điểm lý thuyết: {student1.TheoryMark} và điểm phòng thí nghiệm: {student1.LabMark}");

                // This will throw InvalidMarkException
                Student student2 = new Student(2, "Bob", 12, 5);
                Console.WriteLine($"{student2.Name} có điểm lý thuyết: {student2.TheoryMark} và điểm phòng thí nghiệm: {student2.LabMark}");
            }
            catch (InvalidMarkException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
