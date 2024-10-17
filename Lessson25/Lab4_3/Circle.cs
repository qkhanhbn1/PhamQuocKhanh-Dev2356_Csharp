using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    internal class Circle: Shape
    {
        public void InputData()
        {
            Console.Write("Nhap ban kinh:");
            radius = int.Parse(Console.ReadLine());
        }
        //ghi de phuong thuc tinh dien tich
        public override float Area()
        {
           return 3.14F * radius * radius;
        }
        //ghi de phuowng thuức tính chu vi
        public override float Circumference()
        {
            return 2*3.14F *radius;
        }
    }
}
