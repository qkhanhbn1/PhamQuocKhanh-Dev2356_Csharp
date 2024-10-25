namespace Lab08_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "To", "ve", "hon", "nguoi" };
            //truy vấn dữ liệu 
            IEnumerable<string> result1 = from m in data select m;
            //hiển thị
            Console.WriteLine("Hiển thị kết quả: ");
            foreach (var item in result1)
            {
                Console.Write(item + " ");
            } 
            //truy vấn theo điều kiện lấy các từ là "nguoi"
            IEnumerable<string> result2 = from m in data where m.Equals("nguoi") select m;
            //hiển thị
            Console.WriteLine("\nTruy vấn theo điều kiện");
            foreach(var item in result2)
            {
                Console.WriteLine(item + " ");
            }  
            //sắp xếp dl
            IEnumerable<string> result3 = from m in data orderby m select m;
            //hiển thị
            Console.WriteLine("Hiển thi tất cả kết quả xắp xếp");
            foreach(var item in result3)
            {
                Console.Write(item + " ");
            }   
            //lấy tập dl mới
            var result4 = from m in data select new { Thuong = m.ToLower(),Hoa =m.ToUpper() };
            //hiển thị
            Console.WriteLine("chữ thường và hoa");
            foreach(var item in result4)
            {
                Console.WriteLine(item.Thuong + ":" + item.Hoa);
            }          
        }
    }
}
