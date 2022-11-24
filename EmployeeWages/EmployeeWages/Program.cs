namespace EmployeeWages
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject Airtel = new EmpWageBuilderObject("Airtel", 30, 30, 100);
            EmpWageBuilderObject TCS = new EmpWageBuilderObject("TCS", 40, 30, 80);
            EmpWageBuilderObject Wipro = new EmpWageBuilderObject("Wipro", 25, 25, 120);
            EmpWageBuilderObject Cipla = new EmpWageBuilderObject("Cipla", 23, 28, 111);
            Airtel.computeEmpWage();
            Console.WriteLine(Airtel.toString());
            TCS.computeEmpWage();
            Console.WriteLine(TCS.toString());
            Wipro.computeEmpWage();
            Console.WriteLine(Wipro.toString());
            Cipla.computeEmpWage();
            Console.WriteLine(Cipla.toString());
        }
    }
}