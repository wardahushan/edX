using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSetup
{
    class TechnicalEmployee : Employee
    {
        public TechnicalEmployee(string name) : base(name, 75000)
        {
        }

        public override string EmployeeStatus()
        {
            return ToString() + " has had 10 succesful check-ins.";
        }

    }
}
