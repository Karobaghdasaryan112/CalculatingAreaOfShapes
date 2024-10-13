using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaOfShapes.Library
{
    internal interface ITriangle : IShape
    {
        bool IsRightTriangle();
    }
}
