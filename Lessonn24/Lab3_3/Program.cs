namespace Lab3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tao doi tuong
            StudentModel action = new StudentModel();
            //goi phương thức lấy tất cả sinh viên
            List<Student> listall = action.GetStudent();

            //hien thi
            foreach (var item  in listall)
            {
                item.Display();

            } 
            //goi phương thức lấy sv theo id
            Student st = action.GetStudent(2);

            //hien thi
            st.Display();
            //goi phương thức lấy sv theo tuoi 25-30
            List<Student> listage = action.GetStudent(25,30);
            //ht
            foreach (var item in listage)
            {
                item.Display();
            } 
        }
    }
}
