using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindboxTest
{
    public class Triangle : IFigure
    {
        double EdgeA;
        double EdgeB;
        double EdgeC;   
        
        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (edgeA <= 0)
                throw new ArgumentException("Неверно указана сторона треугольника", nameof(edgeA));

            if (edgeB <= 0)
                throw new ArgumentException("Неверно указана сторона треугольника", nameof(edgeB));

            if (edgeC <= 0)
                throw new ArgumentException("Неверно указана сторона треугольника", nameof(edgeC));

            double perimeter = edgeA + edgeB + edgeC;
            double maxEdge = Math.Max(Math.Max(edgeA, edgeB), edgeC);
            if (perimeter - maxEdge <= maxEdge)
            {
                throw new ArgumentException("Сумма двух меньших сторон должна быть больше наибольшей стороны треугольника");
            }
            this.EdgeA = edgeA;
            this.EdgeB = edgeB;
            this.EdgeC = edgeC;

        }

        public double GetArea()
        {
            double halfPerimeter = (EdgeA + EdgeB + EdgeC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - EdgeA) * (halfPerimeter - EdgeB) * (halfPerimeter - EdgeC));
        }

        public bool isRightTriangle()
        {
            if (EdgeC < EdgeA)
                Util.Swap(ref EdgeC, ref EdgeA);
            if(EdgeC < EdgeB)
                Util.Swap(ref EdgeC, ref EdgeB);
            return Math.Pow(EdgeC, 2) == Math.Pow(EdgeA, 2) + Math.Pow(EdgeB, 2);
        }

    }
}
