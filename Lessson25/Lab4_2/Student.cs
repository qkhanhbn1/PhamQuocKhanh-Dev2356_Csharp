using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    abstract class Student
    {
        protected string name;
        protected int year;

        //khoi tao
        public Student(string name, int year)
        {
            this.name = name;
            this.year = year;

        }
        //hien thi
        protected void Display()
        {
            Console.WriteLine("Name:{0}", name);
            Console.WriteLine("Year: {0}",year);

        }
        //tinh diem trung binh
        public abstract double Average();

    }
}
