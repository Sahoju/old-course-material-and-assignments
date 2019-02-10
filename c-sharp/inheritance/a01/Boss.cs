using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l07 {
    class Boss : Employee {

        public string Car { get; set; } // get; set; when nothing special needs to be done

        public int Bonus { get; set; }

        public Boss() {}

        public Boss(string name, string profession, int salary) : base(name,profession,salary) {
            Name = name;
            Profession = profession;
            Salary = salary;
        }
    }
}
