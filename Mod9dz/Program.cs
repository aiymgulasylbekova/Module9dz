using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9dz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Асылбекова Айым", 20, 80000);
            employee.GetInfo();
            double annualSalary = employee.CalculateAnnualSalary();
            Console.WriteLine($"Годовая зарплата: {annualSalary}");

            Manager manager = new Manager("Асылбекова Асыл", 19, 60000, 10000);
            manager.GetInfo();

            double annualSalaryWithBonus = manager.CalculateAnnualSalary;
            Console.WriteLine($"Годовая зарплата с бонусом: {annualSalaryWithBonus}");
            Developer developer = new Developer("Асылбекова Айша", 21, 50000, 100);
            developer.GetInfo();
            double annualSalaryWithCodePay = developer.CalculateAnnualSalary();
            Console.WriteLine($"Годовая зарплата с учетом доп платы:{annualSalaryWithCodePay}");
            Console.ReadKey();
        }
    }
}
