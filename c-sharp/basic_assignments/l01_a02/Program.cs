// Tee ohjelma, jossa annetaan oppilaalle koulunumero pistetaulukon mukaan. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Give points from a student's test 0-12: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int pts)) {
                if (pts >= 0 && pts <= 1) {
                    Console.WriteLine("Your grade is 0. Try again next semester!");
                } else if (pts >= 2 && pts <= 3) {
                    Console.WriteLine("Your grade is 1. You can do better!");
                } else if (pts >= 4 && pts <= 5) {
                    Console.WriteLine("Your grade is 2. Better than nothing, but still below average!");
                } else if (pts >= 6 && pts <= 7) {
                    Console.WriteLine("Your grade is 3. Not good, but not bad, either. Satisfactory!");
                } else if (pts >= 8 && pts <= 9) {
                    Console.WriteLine("Your grade is 4. Nice!");
                } else if (pts >= 10 && pts <= 12) {
                    Console.WriteLine("Your grade is 5. Exemplary!");
                }
            }
        }
    }
}
