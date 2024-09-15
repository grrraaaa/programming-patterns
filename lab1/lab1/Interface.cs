using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{

    public interface I1
    {
        public int PublicProperty { get; set; }
        public void PublicMethod();
        event EventHandler InfoDisplayed;
        string this[int index] { get; }
    }
    
}
