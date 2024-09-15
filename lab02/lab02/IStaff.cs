using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02 {
    public interface IStaff {
        List<JobVacancy> getJobVacancies();
        List<Employee> getEmployees();
        List<JobTitle> getJobTitles();
        int addJobTitle(JobTitle jobTitle);
        string printJobVacancies();
        bool delJobTitle(int jobTitleId);
        int openJobVacancy(JobVacancy jobVacancy);
        bool closeJobVacancy(int jobVacancyId);
        Employee recruit(JobVacancy jobVacancy, Person person);
        bool dismiss(int jobVacancyId, Reason reason);
    }
}
