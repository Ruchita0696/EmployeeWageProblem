namespace EmployeeWages
{
    public class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        

        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            // Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Comutation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                
                totalEmpHrs += empHrs;
                Console.WriteLine("Days : " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }

            int totalempwage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage of" + company + "is :"  + totalempwage);
            return totalempwage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("Airtel", 30, 30, 100);
            computeEmpWage("TCS", 40, 30, 80);
            computeEmpWage("Wipro", 25, 25, 120);
            computeEmpWage("Cipla", 23, 28, 111);
        }
    }
}