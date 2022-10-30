using Lab6CSharp;

class Hyperbola : IFunction
{
    public double K { get; set; }

    public Hyperbola(double k)
    {
        K = k;
    }

    public  double Calculate(double x)
    {
        return K / x;
    }

    public override string ToString()
    {
        return $"Hyperbola: K-{K}";
    }

    public int CompareTo(IFunction? other)
    {
        if (other is Hyperbola otherHyp)
        {
            return K.CompareTo(otherHyp.K);
        }
        else throw new ArgumentException("Object is not a Hyperbola");
    }

    public object Clone()
    {
        return new Hyperbola(K);
    }
}