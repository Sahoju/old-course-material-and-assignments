using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a05 {
    class Adult : Human {
        public string Car { get; set; }
        public override void Move() {
            Console.WriteLine("Mein führer! I can walk!!");
        }
    }
}
