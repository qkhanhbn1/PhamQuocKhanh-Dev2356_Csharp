namespace Lab07_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Business.House h= new Business.House();
            //gán thông tin
            h.HouseNo = "D249FF";
            h.Price = 123456;
            //in 
            Console.WriteLine("House Detail");
            Console.WriteLine("\t House No: "+h.HouseNo);
            Console.WriteLine("\t Price: " + h.Price);

            Business.Dealership.Car c = new Business.Dealership.Car();
            c.CarNo = "A0999";
            c.Price = 1234567;

            //in
            Console.WriteLine("Car detail");
            Console.WriteLine("\t Car no: "+ h.HouseNo);
            Console.WriteLine("\t Price: " + h.Price);



        }
    }
}
