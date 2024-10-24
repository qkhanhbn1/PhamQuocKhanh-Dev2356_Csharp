namespace Bai07_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Lecture lecture1 = new Lecture("Mr.Khanh", 70000, 8000);
                Console.WriteLine($"{lecture1.Name} có lương: {lecture1.Salary} và thưởng: {lecture1.Bonus}");

              
                Lecture lecture2 = new Lecture("Mr.Khanhh", 50000, 9000);
                Console.WriteLine($"{lecture2.Name} có lương: {lecture2.Salary}và thưởng: {lecture2.Bonus}");
            }
            catch (AmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
