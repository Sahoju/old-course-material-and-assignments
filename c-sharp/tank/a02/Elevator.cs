using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02 {
    class Elevator {
        private int floor = 1;

        public int Floor {
            get {
                return floor;
            }
            set {
                if(value < 1) {
                    Console.WriteLine("You try and try to press something below the first floor button, but there simply isn't anything there.");
                    Console.WriteLine("The elevator stays immobile, taunting your meaningless endeavors.");
                } else if(value > 5) {
                    Console.WriteLine("You realize that this might be the moment that you're able to fly!");
                    Console.WriteLine("Unfortunately this elevator only goes up to floor 5.");
                } else {
                    floor = value;
                }
            }
        }
    }
}
