using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02 {
    public class Person {
        public string name {
            get;
            private set;
        }

        public Person(string name) {
            this.name = name;
        }
    }
}
