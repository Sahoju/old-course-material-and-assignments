using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02 {
    class Edible {
        public string Type { get; set; }
        public int Weight { get; set; }
        public double Space_cm3 { get; set; }

        public Edible(double space_cm3, string type) {
            Space_cm3 = space_cm3;
            Type = type;
        }
    }
}
