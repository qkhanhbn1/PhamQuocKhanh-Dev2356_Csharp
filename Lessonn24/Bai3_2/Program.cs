namespace Bai3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book defaultBook = new Book();
            defaultBook.DisplayInfo();

            Console.WriteLine();

            // Khởi tạo sách với constructor có tham số
            Book myBook = new Book("Khánh", 500, "1", "Harry Potter");
            myBook.DisplayInfo();

            Console.WriteLine();

            // Thử lật trang
            myBook.FlipPageForward(); // Lật sang trang 2
            myBook.FlipPageForward(); // Lật sang trang 3
            myBook.FlipPageBackward(); // Lật về trang 2
            myBook.FlipPageBackward(); // Lật về trang 1
            myBook.FlipPageBackward(); // Đã ở trang đầu
        }
    }
}
