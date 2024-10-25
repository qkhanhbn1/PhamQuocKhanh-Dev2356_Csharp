namespace Bai08_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book(1, "C# Programming", "tacgia A", 1500, "TechBooks", 2015),
                new Book(2, "Introduction ", "tacgia B", 4500, "TechBooks", 2016),
                new Book(3, "Data Structures", "tacgia C", 3000, "EduBooks", 2015),
                new Book(4, "Design Patterns", "tacgia D", 2000, "TechBooks", 2018),
                new Book(5, "Lập trình", "tacgia E", 1000, "EduBooks", 2020),
                new Book(6, "Operating Systems", "tacgia F", 4000, "TechBooks", 2019),
                new Book(7, "Computer Networks", "tacgia G", 5000, "EduBooks", 2017),
                new Book(8, "Web Development", "tacgia H", 1200, "WebBooks", 2021),
                new Book(9, "Software Engineering", "tacgia I", 3500, "EduBooks", 2016),
                new Book(10, "Artificial Intelligence", "tacgia J", 2800, "TechBooks", 2015)
            };

            // Hiển thị tất cả các quyển sách
            Console.WriteLine("Tất cả quyển sách hiện có: ");
            var allBooks = books.Select(b => b);
            foreach (var book in allBooks)
            {
                
                Console.WriteLine($"{book.Name} - {book.Author} - {book.Price} - {book.Publisher} - {book.Year}");
            }
            Console.WriteLine("-------------");
            //Hiển thị những quyển sách có giá từ 1000-5000:
            Console.WriteLine("những quyển sách có giá từ 1000-5000: ");
            var booksByPriceRange = books.Where(b => b.Price >= 1000 && b.Price <= 5000);
            foreach (var book in booksByPriceRange)
            {
                Console.WriteLine($"{book.Name} - {book.Price}");
            }
            Console.WriteLine("-------------");
            //Hiển thị những quyển sách xuất bản năm 2015:
            Console.WriteLine("những quyển sách xuất bản năm 2015: ");
            var booksPublishedIn2015 = books.Where(b => b.Year == 2015);
            foreach (var book in booksPublishedIn2015)
            {
                Console.WriteLine($"{book.Name} - {book.Year}");
            }
            Console.WriteLine("-------------");

            //. Hiển thị những quyển sách có tên "Lập trình":
            Console.WriteLine("những quyển sách có tên 'Lập trình': ");
            var booksWithNameProgramming = books.Where(b => b.Name.Contains("Lập trình"));
            foreach (var book in booksWithNameProgramming)
            {
                Console.WriteLine($"{book.Name} - {book.Author} - {book.Price} - {book.Publisher} - {book.Year}");
            }
            Console.WriteLine("-------------");

            // Đếm các quyển sách của nhà xuất bản Giáo Dục:
            
            var countEduBooks = books.Count(b => b.Publisher == "EduBooks");
            Console.WriteLine($"Số lượng sách của nhà xuất bản Giáo Dục: {countEduBooks}");
            
        }
    }
}
