using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02 {
    class Shelf {
        public List<Liquid> liquids = new List<Liquid>();
        public List<Edible> edibles = new List<Edible>();
        public double space_max;
        public double space;

        public double Space_cm3 {
            get { return space; }
            set {
                if (value > space) {
                    Console.WriteLine("Not enough capacity!");
                } else {
                    space -= value;
                }
            }
        }
        public List<Liquid> Liquids {
            get { return liquids; }
            set { liquids = value; }
        }
        public List<Edible> Edibles {
            get { return edibles; }
            set { edibles = value; }
        }

        public Shelf(double space_cm3) {
            space_max = space_cm3;
            space = space_cm3;
        }
    }
}
