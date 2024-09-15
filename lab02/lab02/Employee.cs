using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02 {
    public class Employee : Person {
        public string department {
            get;
            private set;
        }

        public string job {
            get;
            private set;
        }

        public Employee(string name, string department, string job) : base(name) {
            this.department = department;
            this.job = job;
        }
    }
}
