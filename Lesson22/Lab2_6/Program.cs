namespace Lab2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Thang", "Long", "Hoa", "Dao" };
            Console.Write("Danh sách sinh viên\n");
            foreach(var n in names)
            {
                Console.WriteLine(n);
            } 
                
        }
    }
}
