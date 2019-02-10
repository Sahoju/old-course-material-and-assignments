using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a01 {
    class Vehicle {
        public List<Tire> tires = new List<Tire>(); // Have to initialize the list before able to add to it

        public string Name { get; set; }
        public string Model { get; set; }
        public List<Tire> Tires {   //
            get { return tires; }   // Need to refer to an initialized list
            set { tires = value; }  //
        }
    }
}
