namespace lab02 {
    internal class Program {
        static void Main(string[] args) {
            University univer = new University("Belarusian State Technological University", "BSTU", "Belarus, Minsk");

            Faculty fit = new Faculty("Faculty of Information Technologies", "FIT", "10011-4");
            Faculty lit = new Faculty("Farestry and Ingenering Technologies", "LIT", "311107-1");

            fit.addDepartment(new Department());
            fit.addDepartment(new Department());
            fit.addDepartment(new Department());
            fit.addDepartment(new Department());

            lit.addDepartment(new Department());
            lit.addDepartment(new Department());
            lit.addDepartment(new Department());

            univer.addFaculty(fit);
            univer.addFaculty(lit);

            univer.printInfo();
            foreach (Faculty faculty in univer.getFaculties()) {
                faculty.printInfo();
            }
        }
    }
}