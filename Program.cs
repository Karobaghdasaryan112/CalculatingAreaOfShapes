using CalculatingAreaOfShapes.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaOfShapes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ITriangle shape = new Triangle(4,5,6);
            var Area =shape.CalculateArea();
            Console.WriteLine(Area);
            Console.WriteLine(shape.IsRightTriangle());
        }
    }
}
