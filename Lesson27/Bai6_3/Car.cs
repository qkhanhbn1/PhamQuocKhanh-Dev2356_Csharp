using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_3
{
    internal class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Car(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public override string ToString()
        {
            return $"tên Car: {Name}, Màu: {Color}";
        }
    }
}
