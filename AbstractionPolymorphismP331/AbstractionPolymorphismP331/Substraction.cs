using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPolymorphismP331
{
    internal sealed class Substraction:Calculation
    {
        public override int Operate(int x, int y)
        {
            return x - y;
        }
    }
}
