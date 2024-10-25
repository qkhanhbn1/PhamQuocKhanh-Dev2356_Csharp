namespace Lab08_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new Customer[]
            {
                new Customer{ID=5,Name="Khanh1"},
                new Customer{ID=6,Name="Khanh2"},
                new Customer{ID=7,Name="Khanh3"},
                new Customer{ID=8,Name="Khanh4"},


            };
            //khởi tạo order
            var orders = new Order[]
            {
                new Order{ID = 5,Product="Book1"},
                new Order{ID = 6,Product="Book2"},
                new Order{ID = 7,Product="Book3"},
                new Order{ID = 8,Product="Book4"},

            };
            var query = from c in customers join o in orders on c.ID equals o.ID select new { c.Name, o.Product };

            //hiển thị
            foreach (var group in query)
            {
                Console.WriteLine("{0} bought {1}",group.Name , group.Product);
            }    
        }
    }
}
