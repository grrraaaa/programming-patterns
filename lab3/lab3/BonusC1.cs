using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class BonusC1:IBonus
    {
        public float cost1hour { get; set; }
        private float x { get; set; }
        private float y { get; set; }

        public BonusC1(float cost1hour, float x,float y)
        {
            this.cost1hour = cost1hour;
            this.x = x;
            this.y = y;
        }
        public float calc(float hoursW)
        {
            return hoursW * cost1hour * x+y;
        }
    }
}
