using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSetup
{
    class BusinessEmployee : Employee
    {
        public BusinessEmployee(string name) : base(name, 50000)
        {
            this.EmployeeName = name;
            this.BaseSalary = 50000;
        }

        public override string EmployeeStatus()
        {
            return ToString() + " with a budget of 10000.";
        }

    }
}
