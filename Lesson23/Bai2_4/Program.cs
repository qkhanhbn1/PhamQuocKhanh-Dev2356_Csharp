namespace Bai2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Các số có tổng 3 chữ số là chẵn:");

            for (int i = 100; i <= 999; i++)
            {
                int so = (i / 100) + (i / 10 % 10) + (i % 10);

                if (so % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
