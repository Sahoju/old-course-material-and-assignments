using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a01 {
    class Tire {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }

        public Tire(string name, string model, string size) {
            Name = name;
            Model = model;
            Size = size;
        }
    }
}
