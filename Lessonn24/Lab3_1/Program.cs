namespace Lab3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tao doi tuong car
            Car myCar = new Car();

            //gan gia tri cho cac truong cua doi tuong
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.year = 1995;

            //hien thi thong tin ve  doi tuong mycar
            System.Console.WriteLine("Thông tin chi tiết:");
            System.Console.WriteLine("Make: " + myCar.make);
            System.Console.WriteLine("Model: " + myCar.model);
            System.Console.WriteLine("Color: " + myCar.color);
            System.Console.WriteLine("Year release: " + myCar.year);

            myCar.Start();
            myCar.Stop();


        }
    }
}
