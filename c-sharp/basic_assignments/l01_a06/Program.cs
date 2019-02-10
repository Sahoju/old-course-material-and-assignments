// Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.
// Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä)
// kuluvan bensan määrän sekä bensaan menevän rahan määrän.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a06 {
    class Program {
        static void Main(string[] args) {
            const double litres_per_km = 7.02;
            const double petrol_price = 1.595;
            Console.WriteLine("Give distance: ");
            string line = Console.ReadLine();

            if (double.TryParse(line, out double dist)) {
                double consumption = dist * litres_per_km / 100;
                double cost = consumption * petrol_price;
                Console.WriteLine("Petrol consumption is " + consumption + " liters and its cost is " + cost + " euros.");
            }
        }
    }
}
