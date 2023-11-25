using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9dz
{
    public class Manager : Employee
    {
        public double bonus;


        public Manager(string fio, int age, double salary, double bonus)
            : base(fio, age, salary)
        {
            this.bonus = bonus;
        }
        public new double CalculateAnnualSalary
        {
            get
            {
                double baseSalary = base.CalculateAnnualSalary();
                return baseSalary + bonus;
            }
        }
    }
}
