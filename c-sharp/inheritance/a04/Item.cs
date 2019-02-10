using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a04 {
    class Item {
        public string Name { get; set; }
        public string Type { get; set; }

        public Item() {

        }

        public Item(string name, string type) {
            Name = name;
            Type = type;
        }
    }
}
