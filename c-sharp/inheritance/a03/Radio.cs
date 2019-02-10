using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a03 {
    class Radio {
        private int volume;
        private float frequency;

        public bool PowerState { get; set; }

        public int Volume {
            get {
                return volume;
            }
            set {
                if (value > 10) {
                    Console.WriteLine("Neighbors complain how you're too loud!");
                    volume = 10;
                }
                else if (value < 0) {
                    Console.WriteLine("The radio starts absorbing the surrounding sound! Volume set to 0.");
                    volume = 0;
                }
                else {
                    volume = value;
                }
                Console.WriteLine("Volume set to " + volume + ".\n");
            }
        }

        public float Frequency {
            get {
                return frequency;
            }
            set {
                if (value > 26000.0) {
                    Console.WriteLine("Your head starts tingling and you lose some memories! Frequency set to 26000.0.");
                    frequency = 26000.0f;
                }
                else if (value < 2000.0) {
                    Console.WriteLine("You start spontaneously crapping in your pants! Frequency set to 2000.0.");
                    frequency = 2000.0f;
                }
                else {
                    frequency = value;
                }
                Console.WriteLine("Frequency set to " + frequency + ".\n");
            }
        }


    }
}
