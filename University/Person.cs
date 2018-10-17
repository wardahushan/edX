using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    abstract class Person
    {
        string name;

        string address;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }

        public Person(string name)
        {
            this.name = name;
        }

        public Person()
        {
        }   

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

    }
}
