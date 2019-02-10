using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l07 {
    class Employee {

        public string Name { get; set; } // get; set; when nothing special needs to be done

        public string Profession { get; set; }

        public int Salary { get; set; }

        public Employee() {}

        public Employee(string name, string profession, int salary) {
            Name = name;
            Profession = profession;
            Salary = salary;
        }
    }
}
