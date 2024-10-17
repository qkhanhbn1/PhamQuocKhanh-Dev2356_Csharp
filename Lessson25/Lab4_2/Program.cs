namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khoi tao sv cao dang va in ra tt
            Console.WriteLine("Student of College:");
            StudentCollege sv1= new StudentCollege("Hanh",1992,9.5,8,7);
            sv1.Display();
            Console.WriteLine("Average of socre: {0}", sv1.Average());

            //khoi tao sv dai hoc va in ra tt
            Console.WriteLine("Student of University:");
            StudentUniversity sv2 = new StudentUniversity("Khanh", 2003,10, 10, 10, 10);
            sv2.Display();
            Console.WriteLine("average of score: {0}",sv2.Average());
        }
    }
}
