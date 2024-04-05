using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Rectangle : Shape
    {
        public override void CalculateArea(int en, int uzun)
        {
            Console.WriteLine("Rectangle area: " + en*uzun);
        }
    }
}
