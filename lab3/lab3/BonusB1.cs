using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class BonusB1:IBonus
    {
        public float cost1hour { get; set; }
        private float x { get; set; }

        public BonusB1(float cost1hour, float x)
        {
            this.cost1hour = cost1hour;
            this.x = x;
        }
        public float calc(float hoursW)
        {
            return hoursW * cost1hour*x;
        }
    }
}
