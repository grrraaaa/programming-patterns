using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab1.С3;

namespace lab1
{
    internal class С4
    {
        public class C4 : C3
        {
            public C4()
            {
                Console.WriteLine("C4 Constructor Called");
            }

            public void C4Method()
            {
                Console.WriteLine("Public Method in C4");
                Console.WriteLine(PublicField);
                Console.WriteLine(ProtectedField);
                Console.WriteLine(PublicProperty);
                Console.WriteLine(ProtectedProperty);
            }
        }
    }
}
