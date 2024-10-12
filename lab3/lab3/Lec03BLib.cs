using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    static public partial class Lec03BLib
    {

        static public IFactory getL1()
        {
            return new SalaryForL1();
        }

        static public IFactory getL2(float a)
        {
            return new SalaryForL2(a);
        }
        static public IFactory getL3(float a, float b)
        {
            return new SalaryForL3(a, b);
        }
    }
}
