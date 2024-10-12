using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class BonusC3:IBonus
    {
        public float cost1hour { get; set; }
        private float x { get; set; }
        private float y { get; set; }
        private float A { get; set; }
        private float B { get; set; }

        public BonusC3(float cost1hour, float A, float B, float x, float y)
        {
            this.cost1hour = cost1hour;
            this.x = x;
            this.y = y;
            this.A = A;
            this.B = B;
        }
        public float calc(float hoursW)
        {
            return (hoursW+A) * (cost1hour+B) * x+y;
        }
    }
}
