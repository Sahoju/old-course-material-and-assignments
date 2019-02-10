using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a04 {
    class Machine : Item {
        private bool power = false;

        public string Model { get; set; }
        public int Voltage { get; set; }

        public bool Power() {
            if (power == false) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
