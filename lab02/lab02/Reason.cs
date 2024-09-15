using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02 {
    public class Reason {
        public string description {
            get;
            private set;
        }

        public Reason(string description) {
            this.description = description;
        }
    }
}
