using Store;
namespace Lab07_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo mới nhà phân phối cung cấp đầy đủ namespace
            Supply.Manufacturer dealer = new Supply.Manufacturer();
            //gán giá trị
            dealer.Name = "Coca cola";
            dealer.Email = "cocacola@gmail.com";
            dealer.Phone = "1234567890";
            //in thong tin
            Console.WriteLine("Dealer information");
            Console.WriteLine("\n Name: "+ dealer.Name);
            Console.WriteLine("\n Email: " + dealer.Email);
            Console.WriteLine("\n Phone: " + dealer.Phone);

            Console.WriteLine("-----------------");
            //tạo mới sp nằm trong namespace Store
            StoreItem si = new StoreItem();
            //gán giá trị
            si.ItemNo = 613508;
            si.ItemName = "Fanta";
            si.Price = 80.00M;
            //in thông tin
            Console.WriteLine("Store Inventory");
            Console.Write("\n Item #:     ");
            Console.WriteLine(si.ItemNo);
            Console.Write("\n Item Name:  ");
            Console.WriteLine(si.ItemName);
            Console.Write("\n Item Price: ");
            Console.WriteLine(si.Price);

            Console.Read();
        }
    }
}
