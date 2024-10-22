using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_1
{
    internal class Product
    {
        string name;
        double cost;
        int onhand;
        public Product(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }
        //ghi đè to string
        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C} On hand {2}", name, cost, onhand);
        }
    }
    
}
