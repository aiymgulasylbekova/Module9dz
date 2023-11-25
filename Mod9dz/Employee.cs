using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9dz
{
    public class Employee
    {
        public string fio;
        public double salary;
        public int age;


        public Employee(string fio, int age, double salary)
        {
            this.fio = fio;
            this.salary = salary;
            this.age = age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"ФИО: {fio}, Возраст: {age}, Зарплата: {salary}");
        }
        public double CalculateAnnualSalary()
        {
            return salary * 12;
        }




        public override string ToString()
        {
            return fio + "  " + salary.ToString() + "  " + age.ToString();
        }
    }
}
