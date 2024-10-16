using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_1
{
    internal class Employee
    {
        public int id { get; set; }

        public string name { get; set; }
        public DateTime yearOfBirth { get; set; }
        public double SalaryLevel { get; set; }
        public double basicSalary { get; set; }

        public double GetIncome()
        {
            double InCome = (SalaryLevel * basicSalary);
            return InCome;
        }

        public void Display()
        {
            Console.WriteLine("Định danh: " + id);
            Console.WriteLine("tên: " + name);
            Console.WriteLine("năm sinh: " + yearOfBirth);
            Console.WriteLine("lương cơ bản: " + basicSalary);

        }
    }
}
