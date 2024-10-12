using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class BonusC2:IBonus
    {
        public float cost1hour { get; set; }
        private float x { get; set; }
        private float y { get; set; }
        private float A { get; set; }

        public BonusC2(float cost1hour, float A, float x,float y)
        {
            this.cost1hour = cost1hour;
            this.x = x;
            this.y = y;
            this.A = A;
        }
        public float calc(float hoursW)
        {
            return (hoursW+A) * cost1hour * x+y;
        }
    }
}
