using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_2
{
    internal class Book
    {
        public string Author { get; set; }
        public int Pages { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int CurrentPage { get; private set; }

        // Constructor mặc định
        public Book()
        {
            Author = "Chưa xác định";
            Pages = 0;
            ISBN = "Chưa có ISBN";
            Title = "Chưa có tiêu đề";
            CurrentPage = 1;
        }

        // Constructor có tham số
        public Book(string author, int pages, string isbn, string title)
        {
            Author = author;
            Pages = pages;
            ISBN = isbn;
            Title = title;
            CurrentPage = 1;
        }

        // Phương thức lật sang trang trước
        public void FlipPageForward()
        {
            if (CurrentPage < Pages)
            {
                CurrentPage++;
                Console.WriteLine($"Lật tới trang {CurrentPage}");
            }
            else
            {
                Console.WriteLine("Bạn đang ở trang cuối.");
            }
        }

        // Phương thức lật sang trang sau
        public void FlipPageBackward()
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                Console.WriteLine($"Lật về trang {CurrentPage}");
            }
            else
            {
                Console.WriteLine("Bạn đang ở trang đầu.");
            }
        }

        // Phương thức hiển thị thông tin sách
        public void DisplayInfo()
        {
            Console.WriteLine($"Tác giả: {Author}");
            Console.WriteLine($"Tiêu đề: {Title}");
            Console.WriteLine($"Số trang: {Pages}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Trang hiện tại: {CurrentPage}");
        }
    }
}
