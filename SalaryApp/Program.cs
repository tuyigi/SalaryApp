using System;

namespace SalaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal=new Calculator();
            Console.WriteLine("Please enter employee's ID");
            cal.employee_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter employee's name");
            cal.employee_name = Console.ReadLine();
            Console.WriteLine("Please enter employee's position");
            cal.employee_position = Console.ReadLine();
            Console.WriteLine("Please enter employee's gender");
            cal.employee_gendeer= Console.ReadLine();
            Console.WriteLine("Eneter your gross salary to calculate monthly salary");
            double grossSalary;
            grossSalary = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"{cal.employee_name} your monthly salary on {cal.employee_position} position  is {cal.MonthlySalary(grossSalary)}");
            
            Console.WriteLine("Enter your rate ");
            double rate;
            rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hours of work to calculate your salary");
            double hour;
            hour = Convert.ToDouble(Console.ReadLine());
            if (rate != 0 && hour != 0)
            {
                Console.WriteLine($"{cal.employee_name} Your hourly salary is {cal.HourlySalary(rate,hour)}");
            }
            else
            {
                Console.WriteLine(" Your hourly salary is 0");
            }
            
            
        }
    }
}