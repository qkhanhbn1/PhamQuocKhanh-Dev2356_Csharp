namespace bai2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year, month;
          
            Console.Write("Nhập năm:");
            year= Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tháng:");
            month = Convert.ToInt32(Console.ReadLine());


            // Kiểm tra tính hợp lệ của tháng
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Tháng không hợp lệ. Vui lòng nhập từ 1 đến 12.");
                return;
            }

            // Xác định số ngày trong tháng
            int daysInMonth = DateTime.DaysInMonth(year, month);    

            Console.WriteLine($"Tháng {month} năm {year} có {daysInMonth} ngày.");


        }
    }
}
