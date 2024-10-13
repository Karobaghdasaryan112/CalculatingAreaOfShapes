using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaOfShapes.Library
{

    /// <summary>
    /// Calculating Area For Circle
    /// </summary>
    public class Circle : IShape
    {
        private double _radius;
        public Circle(double _radius)
        {
            this._radius = _radius;
        }
        public double CalculateArea()
        {
            return Math.PI * (Math.Pow(_radius,2));   
        }
    }
    /// <summary>
    /// Calculating Area For Triangle with conditions:
    /// </summary>
    public class Triangle : ITriangle
    {
        private double _sideA,_sideB,_sideC;
        private const int _countOfSides = 3;
        private List<double> _sides;
        private Boolean IsValidTriangle()
        {
            if ((_sideA + _sideB > _sideC) 
                && (_sideB + _sideC > _sideA) 
                && (_sideA + _sideC > _sideB)
                && _sideA > 0
                && _sideB > 0
                && _sideC > 0)
                return true;
            return false;
        }
        public bool IsRightTriangle()
        {
            double sum = 0;
            GetSides();
            for (int index = 1; index < _countOfSides; index++)
            {
                sum += Math.Pow(_sides[index],2);
            }
            if(sum == Math.Pow(_sides[0],2))
                return true;
            return false;
        }
        private List<double> GetSides()
        {
            for (int indexI = 0; indexI < _countOfSides; indexI++)
            {
                for (int indexJ = indexI + 1; indexJ < _countOfSides; indexJ++)
                {
                    if (_sides[indexI] < _sides[indexJ])
                    {
                        double Temp = _sides[indexJ];
                        _sides[indexJ] = _sides[indexI];
                        _sides[indexI] = Temp;
                    }
                }
            }
            return _sides;
        }
        public Triangle(int _sideA, int _sideB, int _sideC)
        {
            this._sideA = _sideA;
            this._sideB = _sideB;
            this._sideC = _sideC;
            _sides = new List<double> { _sideA, _sideB, _sideC };
        }

        public double CalculateArea()
        {
            if (IsValidTriangle())
            {
                double sum = (_sideA + _sideB + _sideC) / 2;
                return Math.Sqrt(sum * (sum - _sideA) * (sum - _sideB) * (sum - _sideC));
            }
            throw new InvalidOperationException(nameof(Triangle));
        }
    }
}
