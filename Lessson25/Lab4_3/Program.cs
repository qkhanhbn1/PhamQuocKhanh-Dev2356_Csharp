namespace Lab4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khoi tao
            Rectangle rec = new Rectangle();
            //nhap dl
            rec.InputData();
            //in thong tin
            Console.WriteLine("Dien tich hinh chu nhat la: {0:N}", rec.Area());
            Console.WriteLine("Chu vi hinh chu nhat la: {0:N}",rec.Circumference());
            //khoi tao hinh tron
            Circle cir = new Circle();
            //nhap dl
            cir.InputData();
            //in
            Console.WriteLine("Dien tich hinh tron la: {0:N}", cir.Area());
            Console.WriteLine("Chu vi hinh tron la: {0:N}", cir.Circumference());
        }
    }
}
