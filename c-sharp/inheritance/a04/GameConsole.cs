using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a04 {
    class GameConsole : Machine{
        public int ControllerCount { get; set; }
        public bool HasDisc { get; set; }

        public void ReadDisc() {
            if (HasDisc == false) {
                Console.WriteLine("There's no disc!");
            }
            else {
                Console.WriteLine("The console reads the inserted disc! Why does the function say \"WRITE\"Line?");
            }
        }
    }
}
