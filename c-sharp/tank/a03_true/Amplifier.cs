using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a03_true {
    class Amplifier {
        private int volume = 10;

        public int Volume {
            get {
                return volume;
            }
            set {
                if (value > 100) {
                    Console.WriteLine("Your neighbors start complaining that your volume is too loud.");
                    volume = 100;
                }
                else if (value < 10) {
                    Console.WriteLine("Your neighbors start gossiping about you being a murderer because you're so silent.");
                    volume = 10;
                }
                else {
                    volume = value;
                }
            }
        }
    }
}
