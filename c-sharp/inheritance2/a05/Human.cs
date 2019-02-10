using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a05 {
    class Human : Mammal {
        public override int Age { get; set; }

        public override void Move() {
            Console.WriteLine("I go...");
        }
    }
}
