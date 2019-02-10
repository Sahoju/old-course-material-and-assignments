using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02 {
    class Boat : Vehicle{
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public Boat() { }

        public Boat(string name, string model, int modelYear, string color, int seatCount, string boatType) : base(name, model, modelYear, color) {
            SeatCount = seatCount;
            BoatType = boatType;
        }
    }
}
