using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a06 {
    class Program {
        static void Main(string[] args) {
            Bathroom bathroom = new Bathroom();
            Water water = new Water();
            water.Color="Clear";
            string merc = "Mercedes";

            bathroom.toilet.PrintColor(water);
            bathroom.shower.PrintCurtains(merc);
        }
    }
}
