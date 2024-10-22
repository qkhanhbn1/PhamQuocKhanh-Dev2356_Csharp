using System.Collections;
namespace Lab06_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList inv = new ArrayList();
            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("B", 8.2, 2));
            inv.Add(new Product("C", 3.5, 4));
            inv.Add(new Product("D", 1.8, 9));

            //in ra
            Console.WriteLine("Product List:");
            foreach (Product i in inv)
            {
                Console.WriteLine("  "+i);
            }    

        }
    }
}
