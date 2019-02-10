using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a05 {
    class Baby : Human {
        public string Diaper { get; set; }
        public override void Move() {
            Console.WriteLine("I am like a little baby!");
        }
    }
}
