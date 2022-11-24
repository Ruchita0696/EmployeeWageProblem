namespace EmployeeWages
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addcompanyEmpWage("Airtel", 30, 30, 100);
            empWageBuilder.addcompanyEmpWage("TCS", 40, 30, 80);
            empWageBuilder.addcompanyEmpWage("Wipro", 25, 25, 120);
            empWageBuilder.addcompanyEmpWage("Cipla", 23, 28, 111);
            empWageBuilder.computeEmpWage();
        }
    }
}