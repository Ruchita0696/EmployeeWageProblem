using EmployeeWages;

namespace Employees
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuildArray empWageBuilder = new EmpWageBuildArray();

            Console.WriteLine("Enter i to Enter Company Details or otherwise enter any key : ");
            var input = Console.ReadLine();
            while (input == "i")
            {
                var obj = UserInput();
                empWageBuilder.addcompanyEmpWage(obj.company, obj.empRatePerHour, obj.numOfWorkingDays, obj.maxHoursPerMonth);
                Console.WriteLine("Enter i to Enter Company Details or otherwise enter any key :");
                input = Console.ReadLine();
            }
            empWageBuilder.computeEmpWage();
        }
        public static CompanyEmpWage UserInput()
        {
            Console.WriteLine("Enter Company Name : ");
            string compName = Console.ReadLine();

            Console.WriteLine("Enter Employee Rate Per Hour : ");
            int empRatePerHour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter No of Working Days : ");
            int numOfDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Maximum Hours Per Month : ");
            int maxWorkingHourPerMonth = Convert.ToInt32(Console.ReadLine());

            return new CompanyEmpWage(compName, empRatePerHour, numOfDays, maxWorkingHourPerMonth)
            {
                company = compName,
                empRatePerHour = empRatePerHour,
                numOfWorkingDays = numOfDays,
                maxHoursPerMonth = maxWorkingHourPerMonth
            };
        }
    }
}