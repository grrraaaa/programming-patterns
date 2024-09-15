using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02 {
    public class University : Organization, IStaff {
        protected List<Faculty> faculties = new List<Faculty>();

        public University() : base() {

        }

        public University(University other) : base(other) {
            this.faculties = other.faculties;
        }

        public University(string name, string shortName, string address) : base(name, shortName, address) {

        }

        public int addFaculty(Faculty faculty) {
            try {
                faculties.Add(faculty);
                return faculties.Count;
            }
            catch {
                return -1;
            }
        }

        public bool delFaculty(int facultyId) {
            try {
                faculties.RemoveAt(facultyId);
                return true;
            }
            catch {
                return false;
            }
        }

        public bool updDepartment(Faculty faculty) {
            return false;
        }

        private bool verFaculty(int facultyId) {
            return faculties.Count > facultyId;
        }

        public List<Faculty> getFaculties() {
            return faculties;
        }

        public new void printInfo() {
            Console.WriteLine($"University '{name}' ({shortName}); {address}; {timeStamp}; {faculties.Count} faculties");
        }
    }
}
