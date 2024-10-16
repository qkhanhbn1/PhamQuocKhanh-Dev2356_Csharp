namespace Bai3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.id = 1;
            e.name = "QUốc Khánh";
            e.yearOfBirth = new DateTime(2003, 8, 26);
            e.SalaryLevel = 50;
            e.basicSalary = 100;
            e.Display();

            double InCome = e.GetIncome();
            Console.WriteLine("Thu nhập: {0}",InCome);
            Console.ReadKey();
        }
    }
}
