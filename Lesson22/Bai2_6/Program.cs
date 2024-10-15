namespace Bai2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập cạnh a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            // Kiểm tra 3 cạnh có tạo thành tam giác không
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Ba cạnh a, b, c tạo thành một tam giác.");

                // Phân loại tam giác
                if (a == b && b == c)
                {
                    Console.WriteLine("Đây là tam giác đều.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Đây là tam giác cân.");
                }
                else if (a * a + b * b == c * c ||
                         a * a + c * c == b * b ||
                         b * b + c * c == a * a)
                {
                    Console.WriteLine("Đây là tam giác vuông.");
                }
                else
                {
                    Console.WriteLine("Đây là tam giác thường.");
                }
            }
            else
            {
                Console.WriteLine("Ba cạnh a, b, c không tạo thành tam giác.");
            }
        }
    }
}
