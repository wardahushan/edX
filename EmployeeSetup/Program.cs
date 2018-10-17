using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalEmployee employee1 = new TechnicalEmployee("Libby");
            TechnicalEmployee employee2 = new TechnicalEmployee("Andrea");
            BusinessEmployee employee3 = new BusinessEmployee("Winter");

            Console.WriteLine(employee1.EmployeeStatus() + "\n" + employee2.EmployeeStatus() + "\n" + employee3.EmployeeStatus());

            employee1.GetEmployeeId();
        }
    }
}
