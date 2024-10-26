using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class SalaryForL2 : IFactory
    {
        private  float A;
        public SalaryForL2(float A)
        {
            this.A = A;
        }
        public IBonus getA(float cost1hour)
        {

            return new BonusA2(cost1hour,A);

        }

        public IBonus getB(float cost1hour, float x)
        {
            return new BonusB2(cost1hour,A, x);
        }

        public IBonus getC(float cost1hour, float x, float y)
        {
            return new BonusC2(cost1hour,A, x, y);
        }
    }
}
