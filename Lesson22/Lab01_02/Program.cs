namespace Lab01_02
{
    //author : khánh
    //date: 14/10/2024
    //objective: chương trình minh họa cách sd biến, hằng , kiểu dl
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai báo biến
            int id = 1;
            string name = "Khánh";
            byte age = 18;
            char gender = 'M';

            //khai báo hằng
            const float percent = 75.50F;

            //hiển thị
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mã số: {0}", id);
            Console.WriteLine("tên :"+ name);
            Console.WriteLine("tuổi :{0}", age);
            Console.WriteLine("giới tính :{0}", gender);
            Console.WriteLine("percent :{0}",percent);
        }
    }
}
