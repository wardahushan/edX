using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Teacher : Person
    {

        private string fullName;
        private string department;

        public string FullName
        {
            get
            {
                return fullName;
            }
            private set
            {
                if (value != null)
                {
                    fullName = value;
                }
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            private set
            {
                if (value != null)
                {
                    department = value;
                }
            }
        }

        public Teacher(string fullname, string department) : base(fullname, department)
        {
            this.FullName = fullname;
            this.Department = department;
        }

    }
}