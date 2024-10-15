namespace Bai2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10; // Số dòng của tam giác

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ',(n-i)));
                int num = i;
                // In khoảng trắng để căn giữa
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num % 10);
                    num++;
                }
                num -= 2;
                // In các số tăng dần
                for (int j = 1; j < i; j++)
                {
                    Console.Write(num % 10);
                    num--;
                }
                Console.WriteLine();
            }
        }
    }
}
