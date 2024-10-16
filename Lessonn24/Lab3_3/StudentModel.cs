using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    internal class StudentModel
    {
        List<Student> liststudent;

        public StudentModel() { 
        this.liststudent = new List<Student>
        {
            new Student(){Id =1,Name="Dung",Age=20},
            new Student(){Id =2,Name="Tuan",Age=25},
            new Student(){Id =3,Name="Anh",Age=18},
            new Student(){Id =4,Name="HOang",Age=30},
            new Student(){Id =5,Name="Son",Age=24},
        };
        }
        #region cac phuong thuc overloading
        public List<Student> GetStudent()
        {
            return liststudent;
        }
        public Student GetStudent(int id)
        {
            Student st = null;
            foreach (var item  in liststudent)
            {
                if (item.Id == id) 
                    st = item;
            }
            return st;
                
        }
        //phuong thức trả về sinh viên có tuổi từ x to y
        public List<Student> GetStudent(int x , int y)
        {
            List<Student> result  = new List<Student>();
            foreach (var item in liststudent)
            {
                if(item.Age >= x && item.Age <= y)
                    result.Add(item);
            }    
            return result;

        }
        #endregion

    }
}
