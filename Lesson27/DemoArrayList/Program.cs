using System.Collections;

namespace DemoArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DemoArrayList");
            //khoi taoj
            ArrayList arrayList = new ArrayList();

            //thêm các phần tử
            //add
            arrayList.Add(111);
            arrayList.Add("Khanh");
            //addRange

            string[] strs = { "Tung", "Hoa", "Mai", "Huệ" };
            arrayList.AddRange(strs);

            //in mảng
            printArray(arrayList);
            //insert
            arrayList.Insert(0, "Devmaster");
            printArray(arrayList);

            //remove
            arrayList.Remove("Devmaster");
            printArray(arrayList);

            arrayList.RemoveAt(1);
            printArray(arrayList);

            //sort
            arrayList.AddRange(strs);
            printArray(arrayList);
            arrayList.Sort();
            printArray(arrayList);

        }
        static void printArray(ArrayList arrayList)
        {
            Console.WriteLine("Danh sách các phần tử");
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("----------------------");
        }
    }
}
