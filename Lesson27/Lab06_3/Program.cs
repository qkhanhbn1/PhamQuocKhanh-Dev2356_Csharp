namespace Lab06_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student { Id = "S10", FirstName = "Nguyen Thu", LastName = "Phương", Avg = 9.5 },
                new Student{ Id = "S11", FirstName = "Tran Thi", LastName = "A", Avg =1 },
                new Student{ Id = "S12", FirstName = "Nguyễn Thu", LastName = "B", Avg = 2 },
                new Student{ Id = "S13", FirstName = "Nguyễn Thu", LastName = "C", Avg = 3 },
                new Student{ Id = "S14", FirstName = "Nguyễn Thu", LastName = "D", Avg = 4 },
                new Student{ Id = "S15", FirstName = "Nguyễn Thu", LastName = "R", Avg = 5 },
                new Student{ Id = "S16", FirstName = "Nguyễn Thu", LastName = "E", Avg = 6 },

            };

            //in danh sách sv
            Console.Write("Danh sach snh vien");
            foreach(var st in list)
            {
                Console.WriteLine(st);
            }   
            //tìm sv có điểm trung bình cao nhất
            double max = list[0].Avg;
            Student stmax = list[0];
            foreach(var st in list)
            {
                if(st.Avg > max)
                {
                    max = st.Avg;
                    stmax = st;

                }    
            }
            Console.Write("Sinh vien co diem cao nhat la:");
            Console.Write(stmax);
        }
    }
}
