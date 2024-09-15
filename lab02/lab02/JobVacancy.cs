using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02 {
    public class JobVacancy {
        public string title {
            get;
            private set;
        }

        public bool isOpened {
            get;
            private set;
        }

        public JobVacancy(string title) {
            this.title = title;
            isOpened = false;
        }

        public void Open() {
            isOpened = true;
        }

        public void Close() {
            isOpened = false;
        }
    }
}
