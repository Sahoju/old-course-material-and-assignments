using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02 {
    class Fridge {
        public List<Shelf> shelf = new List<Shelf>();
        public int shelfAmount = 4;

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public List<Shelf> Shelves {
            get { return shelf; }
            set { shelf = value; }
        }
    }
}
