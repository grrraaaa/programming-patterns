using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class BonusB2:IBonus
    {
        public float cost1hour { get; set; }
        private float x { get; set; }
        private float A { get; set; }

        public BonusB2(float cost1hour, float A,float x)
        {
            this.cost1hour = cost1hour;
            this.A = A;
            this.x = x;
        }
        public float calc(float hoursW)
        {
            return (hoursW + A) * cost1hour*x;
        }
    }
}
