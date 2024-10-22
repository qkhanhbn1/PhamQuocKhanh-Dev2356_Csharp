
namespace Lab06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string , string> listEm = new SortedList<string , string>();
            //đưa dl vào
            listEm.Add("E01", "Tran thi Thuy");
            listEm.Add("E02", "Le Hai Ha");
            listEm.Add("E03", "Nguyen Van Hung");
            listEm.Add("E04", "Tran thi Thuy");
            listEm.Add("E05", "Tran thi Thuy");
            //in danh sách
            Console.WriteLine("Danh sách nhân viên");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key+ ":" + listEm[key]);
            }
            Console.WriteLine("--------------------");
            //tìm kiếm nv có chữ th
            Console.WriteLine("Nhan vien bat dau bang chu th");
            foreach(var key in listEm.Keys)
            {
                if(listEm[key].StartsWith("Th"))
                    Console.WriteLine(key + ":" + listEm[key]);
            }
            //xóa nv có mã E04
            listEm.Remove("E04");
            //kiểm tra nếu chưa có nv E06 thì thêm 
            if (!listEm.ContainsKey("E06"))
                listEm.Add("E06", "Nguyen Hoai Linh");
            //in ra sau khi thêm, xoa
            Console.WriteLine("Danh sach nhan vien sau khi xoa, them");
            foreach (var key in listEm.Keys)

            {
                Console.WriteLine(key+":"+ listEm[key]);
            }
        }
    }
}
