namespace SalaryApp
{
    public class Calculator
    {
        public int employee_id;
        public string employee_name;
        public string employee_position;
        public string employee_gendeer;

        public double calculateSalary(double grossSalary)
        {
            double salary;
            salary = grossSalary - (((grossSalary * 30) / 100) + ((grossSalary * 5) / 100) + ((grossSalary * 3) / 100));
            return salary;
        }

        public double calculateSalary(double rate, double hour)
        {
            double salary;
            salary=(rate*hour)-((((rate*hour)*5)/100)+(((rate*hour)*3)/100));
            return salary;
        }

        public int calculateSalary(int grossSalary)
        {
            int salary;
            salary = grossSalary - ((grossSalary * 30) / 100);
            return salary;
        }
    }
}