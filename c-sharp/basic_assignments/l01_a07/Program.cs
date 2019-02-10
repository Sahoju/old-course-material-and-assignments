// Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a07 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Give a year: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int year)) {
                if (year % 400 == 0) {
                    Console.WriteLine("It's a leap year. Did you know that years divided by 400 are leap years?");
                }
                else if (year % 100 == 0) {
                    Console.WriteLine("It's not a leap year. Did you know that years divided by 100 are not leap years save for years divided by 400?");
                }
                else if (year % 4 == 0) {
                    Console.WriteLine("It's a leap year, hoppity hop. Astronomical!");
                } else {
                    Console.WriteLine("It's not a leap year. How do birthdays work during the leap day?");
                }
            }
        }
    }
}
