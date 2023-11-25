using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9dz
{
    public class Developer : Employee
    {
        private int codeofDay;
        public Developer(string fio, int age, double salary, int codeofDay)
            : base(fio, age, salary)
        {
            this.codeofDay = codeofDay;
        }

        public new double CalculateAnnualSalary
        {
            get
            {
                double baseSalary = base.CalculateAnnualSalary();
                return baseSalary + (codeofDay * 1);
            }
        }
    }

}
