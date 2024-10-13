using CalculatingAreaOfShapes.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatingAreaOfShapes
{
    public class TestForTriangle
    {
        [Fact]
        public void CorrectArea()
        {
            IShape TriangleShape = new Triangle(6, 8, 10);

            double Area = TriangleShape.CalculateArea();

            Assert.Equal(24, Area); 
        }

        [Fact]
        public void CalculateArea_ThrowInvalidOperationException()
        {
            ITriangle triangle = new Triangle(2,2,3);

            Exception CalculateException = Assert.Throws<InvalidOperationException>(() => triangle.CalculateArea());

            Assert.Equal("Triangle",CalculateException.Message);
        }

        [Fact]
        public void Triangle_IsRight()
        {
            ITriangle triangle = new Triangle(5, 6, 7); 

            bool isRight = triangle.IsRightTriangle();

            Assert.False(isRight);
        }
    }
}
