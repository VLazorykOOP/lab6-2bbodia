using Lab6CSharp;

class Quadratic : IFunction
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Quadratic(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public  double Calculate(double x)
    {
        return A * Math.Pow(x, 2) + B * x + C;
    }

    public override string ToString()
    {
        return $"Quadratic: A-{A}  B-{B}  C-{C}";
    }

    public int CompareTo(IFunction? other)
    {
        if (other is Quadratic otherQuadratic)
        {
            return C.CompareTo(otherQuadratic.C);
        }
        else throw new ArgumentException("Object is not a Quadratic");
    }

    public object Clone()
    {
        return new Quadratic(A, B, C);
    }
}
