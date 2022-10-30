using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public interface IFunction : IComparable<IFunction>,ICloneable
    {
        public double Calculate(double x);
    }
}
