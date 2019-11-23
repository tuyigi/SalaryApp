namespace SalaryApp
{
    public class Calculator
    {
        public int employee_id;
        public string employee_name;
        public string employee_position;
        public string employee_gendeer;

        public double MonthlySalary(double grossSalary)
        {
            double salary;
            salary = grossSalary - (((grossSalary * 30) / 100) + ((grossSalary * 5) / 100) + ((grossSalary * 3) / 100));
            return salary;
        }
    }
}