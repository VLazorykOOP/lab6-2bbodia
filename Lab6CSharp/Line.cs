using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class Line : IFunction
    {
        private double A { get; set; }
        private double B { get; set; }

        public Line(double a, double b)
        {
            A = a;
            B = b;
        }
        public double Calculate(double x)
        {
            return A * x + B;
        }

        public object Clone()
        {
            return new Line(A, B);
        }

        public override string ToString()
        {
            return $"Line : A-{A} B-{B}";
        }
        public int CompareTo(IFunction? other)
        {
            if (other is Line otherLine)
            {
                return B.CompareTo(otherLine.B);
            }
            else throw new ArgumentException("Object is not a Line");
        }
    }
}
