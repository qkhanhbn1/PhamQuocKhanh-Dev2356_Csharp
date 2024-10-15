namespace Bai2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id, name,Adress;
            DateTime Birthday;
            double salary, bonus;

            id = "NV1";
            name = "Khánh";
            Adress = "bn";
            Birthday = new DateTime(2003,8,26);
            salary = 1000;
            bonus = 1;
            

            Console.WriteLine("\n Thong tin nhan vien");
            Console.WriteLine("Mã nv: " + id);
            Console.WriteLine("Tên nv: " + name);
            Console.WriteLine("Địa chỉ:" + Adress);
            Console.WriteLine("Ngay sinh:{0:dd/MM/yyyy}", Birthday);
            Console.WriteLine("tiền lương: {0}" , salary);
            Console.WriteLine("thêm: {0} ",bonus);
            Console.WriteLine("TotalSalary: {0}",salary+ bonus);

        }
    }
}
