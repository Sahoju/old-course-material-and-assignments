// Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0.
// Ohjelman tulee tulostaa syötettyjen lukujen summa.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a09 {
    class Program {
        static void Main(string[] args) {
            double sum = 0;
            double num = 1;
            Console.WriteLine("Give numbers. Type 0 to stop giving numbers");
            while (num != 0) {
                string line = Console.ReadLine();
                if (double.TryParse(line, out num)) {
                    sum += num;
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
