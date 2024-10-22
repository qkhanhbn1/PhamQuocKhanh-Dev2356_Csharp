namespace Bai6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
        {
            new Book(1, "s1", "tacgia 1", "Nhi Dong", 2014, 50),
            new Book(2, "s2", "tacgia 2", "Publisher 2", 2014, 40),
            new Book(3, "s3", "tacgia 3", "Publisher 3", 2010, 60),
            new Book(4, "s4", "tacgia 4", "Nhi Dong", 2016, 70),
            new Book(5, "s5", "tacgia 5", "Publisher 5", 2014, 30),
            new Book(6, "s6", "tacgia 6", "Publisher 6", 2020, 90),
            new Book(7, "s7", "tacgia 7", "Publisher 7", 2019, 35),
            new Book(8, "s8", "tacgia 8", "Publisher 8", 2021, 55),
            new Book(9, "s9", "tacgia 9", "Nhi Dong", 2017, 45),
            new Book(10, "s10", "tacgia 10", "Publisher 10", 2014, 80)
        };

            // 1. In danh sách các quyển sách tăng dần theo giá
            var sortedBooks = books.OrderBy(b => b.Price).ToList();
            Console.WriteLine("Sách sắp xếp theo giá:");
            sortedBooks.ForEach(b => Console.WriteLine(b));

            // 2. Tìm quyển sách có title trùng với giá trị nhập từ bàn phím
            Console.WriteLine("Nhập title sách:");
            string title = Console.ReadLine();
            var foundBook = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (foundBook != null)
            {
                Console.WriteLine($"Đã tìm thấy sách: {foundBook}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sách.");
            }

            // 3. Đưa ra những quyển sách xuất bản năm 2014
            Console.WriteLine("Sách xuất bản năm 2014:");
            var books2014 = books.Where(b => b.Year == 2014).ToList();
            books2014.ForEach(b => Console.WriteLine(b));

            // 4. Xóa những quyển sách của nhà xuất bản “Nhi Dong”
            books.RemoveAll(b => b.Publisher == "Nhi Dong");
            Console.WriteLine("Sách sau khi xóa sách nhà xuất bản 'Nhi Đồng':");
            books.ForEach(b => Console.WriteLine(b));
        }
    }
}
