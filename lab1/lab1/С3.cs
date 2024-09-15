using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class С3
    {
        public class C3
        {
            public string PublicField = "Public Field in C3";

            protected string ProtectedField = "Protected Field in C3";

            private string PrivateField = "Private Field in C3";

            public string PublicProperty { get; set; } = "Public Property in C3";

            protected string ProtectedProperty { get; set; } = "Protected Property in C3";

            public C3()
            {
                Console.WriteLine("C3 Constructor Called");
            }

            public void PublicMethod()
            {
                Console.WriteLine("Public Method in C3");
            }

            protected void ProtectedMethod()
            {
                Console.WriteLine("Protected Method in C3");
            }
            private void PrivateMethod()
            {
                Console.WriteLine("Private Method in C3");
            }
        }
    }
}
