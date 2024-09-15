using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02 {
    public class Organization : IStaff {
        protected List<JobVacancy> jobVacancies = new List<JobVacancy>();
        protected List<JobTitle> jobTitles = new List<JobTitle>();
        protected List<Employee> employees = new List<Employee>();

        public int id {
            get;
            private set;
        }

        public string name {
            get;
            protected set;
        }

        public string shortName {
            get;
            protected set;
        }

        public string address {
            get;
            protected set;
        }

        public DateTime timeStamp {
            get;
            protected set;
        }

        public Organization() {
            name = string.Empty;
            shortName = string.Empty;
            address = string.Empty;
            timeStamp = DateTime.Now;
        }

        public Organization(Organization other) {
            this.jobVacancies = other.jobVacancies;
            this.jobTitles = other.jobTitles;
            this.employees = other.employees;
            this.id = other.id;
            this.name = other.name;
            this.shortName = other.shortName;
            this.address = other.address;
            this.timeStamp = other.timeStamp;
        }

        public Organization(string name, string shortName, string address) {
            this.name = name;
            this.shortName = shortName;
            this.address = address;
            timeStamp = DateTime.Now;
        }

        public void printInfo() {
            Console.WriteLine($"Organization '{name}' ({shortName}); {address}; {timeStamp}");
        }

        public List<JobVacancy> getJobVacancies() {
            return jobVacancies;
        }

        public List<JobTitle> getJobTitles() {
            return jobTitles;
        }

        public List<Employee> getEmployees() {
            return employees;
        }

        public int addJobTitle(JobTitle jobTitle) {
            try {
                jobTitles.Add(jobTitle);
                return jobTitles.Count;
            }
            catch {
                return -1;
            }
        }

        public string printJobVacancies() {
            return string.Join('\n', jobVacancies.Select(jv => $"{jv.title} [{jv.isOpened}]"));
        }

        public bool delJobTitle(int jobTitleId) {
            try {
                jobTitles.RemoveAt(jobTitleId);
                return true;
            }
            catch {
                return false;
            }
        }

        public int openJobVacancy(JobVacancy jobVacancy) {
            try {
                int index = jobVacancies.FindIndex(jb => jb.title == jobVacancy.title);
                jobVacancies[index].Open();
                return index;
            }
            catch {
                return -1;
            }
        }

        public bool closeJobVacancy(int jobId) {
            try {
                jobVacancies[jobId].Close();
                return true;
            }
            catch {
                return false;
            }
        }

        public Employee recruit(JobVacancy jobVacancy, Person person) {
            return new Employee(person.name, name, jobVacancy.title);
        }

        public bool dismiss(int jobId, Reason reason) {
            Console.WriteLine($"{jobId} dissmissed because of {reason.description}");
            return true;
        }
    }
}
