namespace EmployeeWages
{
    public class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HOURS_IN_MONTH = 100;

        public static int computeEmpWage()
        {
            // Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_HOURS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {

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
                totalWorkingDays++;
                totalEmpHrs += empHrs;
                Console.WriteLine("Days : " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }

            int totalempwage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalempwage);
            return totalempwage;
        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }
    }
}