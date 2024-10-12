using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class BonusA1:IBonus
    {
        public float cost1hour { get; set; }

        public BonusA1(float cost1hour)
        {
            this.cost1hour=cost1hour;
        }
        public float calc(float hoursW) 
        {
            return hoursW * (cost1hour);
        }
    }
}
