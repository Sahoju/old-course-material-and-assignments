using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a04 {
    class Computer : Machine {
        public string GFX { get; set; }
        public string CPU { get; set; }
        public int RAM { get; set; }
        public string Motherboard { get; set; }
        public string PowerSupply { get; set; }
        public string UsedFor { get; set; }
    }
}
