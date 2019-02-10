using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02 {
    class Vehicle {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        public Vehicle() {}

        public Vehicle(string name, string model, int modelYear, string color) {
            Name = name;
            Model = model;
            ModelYear = modelYear;
            Color = color;
        }
    }
}
