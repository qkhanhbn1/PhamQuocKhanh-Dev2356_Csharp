namespace Lab4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tao 1 nvien
            Iperson staff = new Staff();
            object data = "Bach Khoa Aptech";
            //goi cac hanh dong
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);

            //tao sv
            Iperson student = new Student() { Id = "S10", Name = "Khánh", Age = 20 };

            student.Display(student);
        }

    }
}
