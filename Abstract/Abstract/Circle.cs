using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Circle : Shape
    {
        public override void CalculateArea(int Radius, int p=3)
        {
            Console.WriteLine("Circle area: " + Radius* Radius*p);
        }
    }
}
