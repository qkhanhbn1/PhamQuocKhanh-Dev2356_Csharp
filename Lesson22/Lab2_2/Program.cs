namespace Lab2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Nhap vao ky tu:");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case '0':
                case 'e':
                case 'u':
                case 'i': Console.WriteLine("{0} là nguyen am.", ch);
                    break;
                default:Console.WriteLine("{0} là phụ âm.", ch);
                    break;

            }

        }
    }
}
