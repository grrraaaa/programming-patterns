using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class SalaryForL3:IFactory
    {
        private float A { get; set; }

        private float B { get; set; }
        public SalaryForL3(float A, float B)
        {

            this.A = A;
            this.B = B;
        }
        public IBonus getA(float cost1hour)
        {

            return new BonusA1(cost1hour);

        }

        public IBonus getB(float cost1hour, float x)
        {
            return new BonusB1(cost1hour, x);
        }

        public IBonus getC(float cost1hour, float x, float y)
        {
            return new BonusC1(cost1hour, x, y);
        }
    }
}
