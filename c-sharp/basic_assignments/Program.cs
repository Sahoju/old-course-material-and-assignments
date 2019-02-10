// Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a03 {
    class Program {
        static void Main(string[] args) {
            const int turns = 3;
            string line;
            int num = 0;
            int mean;

            Console.WriteLine("Give three numbers: ");
            for (int i = 0; i < turns; i++) {
                line = Console.ReadLine();
                if (int.TryParse(line, out int temp)) {
                    num += temp;
                }
            } // for
            mean = num / turns;
            Console.WriteLine("Sum: " + num + "\nMean: " + mean);
        }
    }
}
