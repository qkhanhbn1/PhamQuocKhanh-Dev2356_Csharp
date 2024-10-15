namespace Bai2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số giây: ");
            int sogiay = Convert.ToInt32(Console.ReadLine());

            int hours = sogiay / 3600;
            int minutes = (sogiay % 3600) / 60;
            int seconds = sogiay % 60;

            Console.WriteLine($"Định dạng hh:mm:ss là: {hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
