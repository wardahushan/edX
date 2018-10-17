using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSetup
{
    abstract class Employee
    {
        private string employeeName;

        private double baseSalary;

        private int employeeId;

        private static int employeeCount = 1;

        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public double BaseSalary { get => baseSalary; set => baseSalary = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }

        public Employee(string name, double baseSalary)
        {
            EmployeeName = name;
            BaseSalary = baseSalary;
            EmployeeId = employeeCount++;
        }

        public double GetBaseSalary()
        {
            return BaseSalary;
        }

        public string GetName()
        {
            return EmployeeName;
        }

        public int GetEmployeeId()
        {
            return EmployeeId;
        }

#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public string ToString()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            return EmployeeId + " " + EmployeeName;
        }

        public abstract string EmployeeStatus();
    }
}
