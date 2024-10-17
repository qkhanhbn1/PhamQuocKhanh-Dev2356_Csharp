using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    internal class Rectangle:Shape
    {
        public void InputData()
        {
            Console.Write("Nhap chieu dai:");
            length= int.Parse( Console.ReadLine() );
            Console.Write("Nhap chieu rong:");
            width = int.Parse(Console.ReadLine());
        }
        //ghi de phthuc tinh dien tich
        public override float Area()
        {
            return length*length;
        }
        public override float Circumference()
        {
            return 2*length*width;
        }
    }
}
