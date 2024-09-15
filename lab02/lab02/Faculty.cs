using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02 {
    public class Faculty : Organization, IStaff {
        protected List<Department> departments = new List<Department>();

        public Faculty() : base() {

        }

        public Faculty(Faculty other) : base(other) {
            this.departments = other.departments;
        }

        public Faculty(string name, string shortName, string address) : base(name, shortName, address) {

        }

        public int addDepartment(Department department) {
            try {
                departments.Add(department);
                return departments.Count;
            }
            catch { 
                return -1;
            }
        }

        public bool delDepartment(int departmentId) {
            try {
                departments.RemoveAt(departmentId);
                return true;
            }
            catch { 
                return false;
            }
        }

        public bool updDepartment(Department department) {
            return false;
        }

        private bool verDepartment(int departmentId) {
            return departments.Count > departmentId;
        }

        public List<Department> getDepartments() {
            return departments;
        }

        public new void printInfo() {
            Console.WriteLine($"Faculty '{name}' ({shortName}); {address}; {timeStamp}; {departments.Count} departments");
        }
    }
}
