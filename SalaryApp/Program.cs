using System;

namespace SalaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal=new Calculator();
            Console.WriteLine("Enter employee id");
            cal.employee_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            cal.employee_name = Console.ReadLine();
            Console.WriteLine("Enter employee position");
            cal.employee_position = Console.ReadLine();
            Console.WriteLine("Enter employee gender");
            cal.employee_gendeer= Console.ReadLine();
            Console.WriteLine("Enter employee gross salary");
            double grossSalary;
            grossSalary = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"{cal.employee_name} your monthly salary on position of {cal.employee_position}   is {cal.calculateSalary(grossSalary)}");
            int salary;
            Console.WriteLine("Enter gross salary to calculate one time salry");
            salary = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"{cal.employee_name} your one-time salary on position of {cal.employee_position} is {cal.calculateSalary(salary)}");
                
            Console.WriteLine("Enter your rate ");
            double rate;
            rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hours of working");
            double hour;
            hour = Convert.ToDouble(Console.ReadLine());
            if (rate != 0 && hour != 0)
            {
                Console.WriteLine($"{cal.employee_name} Your hourly salary is {cal.calculateSalary(rate,hour)}");
            }
            else
            {
                Console.WriteLine(" Your hourly salary is 0");
            }
            
           
            
            
        }
    }
}