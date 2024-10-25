
namespace Lab08_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 7, 9, 3, 5, 2, 1, 0, 6, 4, 3, 1 };
            string[] Words =
            {
                "Chi","trích","phê","phán","người","khác"
            };
            List<Film> ListFilm = new List<Film>()
            {
                new Film { FilmId = "F01", FilmName = "Điệp viên 007", Price = 1 },
                new Film { FilmId = "F02", FilmName = "Điệp viên 0072", Price = 2 },
                new Film { FilmId = "F03", FilmName = "Điệp viên 0073", Price = 3 },
                new Film { FilmId = "F04", FilmName = "Điệp viên 0074", Price = 4 },
                new Film { FilmId = "F05", FilmName = "Điệp viên 0075", Price = 5 },
                new Film { FilmId = "F06", FilmName = "Điệp viên 0076", Price = 6 },
                new Film { FilmId = "F07", FilmName = "Điệp viên 0077", Price = 7 },

            };
            //lọc các số chẵn
            IEnumerable<int> querynumber = Numbers.Where(n => n % 2 == 0);
            Show<int>(querynumber,"Lọc các số chẵn: ");
            //lọc các từ có độ dài >4
            IEnumerable<string> queryword = Words.Where(w => w.Length > 4);
            Show<string>(queryword, "Lọc các từ có độ dài >4: ");
            //lọc các từ có tên bắt đầu bằng chữ t
            IEnumerable<string> queryT = Words.Where(w => w.StartsWith("t"));
            Show<string>(queryT, "Loc cac tu bat dau bang chu t: ");
            //Lọc các số duy nhất trong tập các số
            var uniqueNumber = Numbers.Distinct();
            Show<int>(uniqueNumber, "Lọc các số duy nhất trong tập các số:");

            //Đếm xem có bao nhiêu từ không trùng nhau
            var countDistinct = Words.Distinct().Count();
            Console.WriteLine("Đếm xem có bao nhiêu từ không trùng nhau:" + countDistinct);

            //Lấy 4 số đầu tiên trong dãy
            var fourNumber = Numbers.Take(4);
            Show<int>(fourNumber, "Lấy 4 số đầu tiên trong dãy:");

            //Lấy 2 từ đầu tiên trong câu
            var twoword = Words.Take(2);
            Show<string>(twoword, "Lấy 2 từ đầu tiên trong câu:");

            //Lấy những từ đầu tiên có chứa chữ 't'
            var searchword = Words.TakeWhile(w => w.Contains('t'));
            Show<string>(searchword, "Lấy những từ đầu tiên có chứa chữ 't':");

            //Sắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá < 200000
            var queryfilm = ListFilm.OrderBy(f => f.Price)
                .Select(x => new { x.FilmId, x.FilmName, x.Price })
                .ToList().TakeWhile(t => t.Price < 200000);

            //Bỏ qua 3 phần tử đầu tiên, lấy tất cả các phần tử còn lại
            var skipNumber = Numbers.Skip(3);
            //Bỏ qua 3 phần tử đầu tiên, lấy tất cả các phần tử còn lại
            Show<int>(skipNumber, "Bỏ qua 3 phần tử đầu tiên, lấy tất cả các phần tử còn lại:");

            //Bỏ qua 4 phần tử đầu tiên lấy 3 phần tử kế tiếp
            var skipTakeNumber = Numbers.Skip(4).Take(3);
            Show<int>(skipTakeNumber, "Bỏ qua 4 phần tử đầu tiên, lấy 3 phần tử kế tiếp:");

            //Bỏ qua 3 phim đầu tiên lấy 3 phim kế tiếp (có thể áp dụng để phân trang)
            var skipTakeFilm = ListFilm.Skip(3).Take(3);
            Show<Film>(skipTakeFilm, "Bỏ qua 3 phim đầu tiên, lấy 3 phim kế tiếp:");

            //Sắp xếp giảm dần, sau đó lấy các phần tử <5
            var sortNumber = Numbers.OrderByDescending(x => x).SkipWhile(x => x > 5);
            Show<int>(sortNumber, "Sắp xếp giảm dần, sau đó lấy các phần tử <5:");
        }
        static void Show<T>(IEnumerable<T> data, string message)
        {
            Console.WriteLine(message);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            } 
                
        }    
    }
}
