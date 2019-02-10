// Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta,
// tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a04 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Give your age: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int age)) {
                if (age >= 0 && age < 18) {
                    Console.WriteLine("You're underaged! At this rate you'll become a perverted child!");
                }
                else if (age >= 18 && age < 65) {
                    Console.WriteLine("You're an adult. Is \"Being an adult\" bound by age? What does it mean to be an adult?");
                }
                else if (age >= 65) {
                    Console.WriteLine("You're a senior. Your body is starting to deteriorate, but you have all the time in your hands, so does it matter?");
                }
                else {
                    Console.WriteLine("Wait a minute! How'd you get here?");
                }
            }
        }
    }
}
