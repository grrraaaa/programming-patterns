using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class BonusB3:IBonus
    {
        public float cost1hour { get; set; }
        private float A { get; set; }
        private float B { get; set; }
        private float x { get; set; }

        public BonusB3(float cost1hour, float A,float B, float x)
        {
            this.cost1hour = cost1hour;
            this.A = A;
            this.B = B;
            this.x = x;
        }
        public float calc(float hoursW)
        {
            return (hoursW + A) * (cost1hour+B)*x;
        }
    }
}
