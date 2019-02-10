using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02 {
    class Bicycle : Vehicle {
        public bool Gears { get; set; }
        public string GearName { get; set; }

        public Bicycle() { }

        public Bicycle(string name, string model, int modelYear, string color, bool gears, string gearName) : base(name, model, modelYear, color) {
            Gears = gears;
            GearName = gearName;
        }
    }
}
