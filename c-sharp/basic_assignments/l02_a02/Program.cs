// Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon.
// Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l02_a02 {
    class Program {
        static void Main(string[] args) {
            int[] array = new int[5];
            Console.WriteLine("Give five integers: ");
            for(int i = 0; i < 5; i++) {
                string line = Console.ReadLine();
                if (int.TryParse(line, out array[i])) {}
            }

            for(int i = 4; i >= 0; i--) {
                Console.Write(array[i] + " ");
            }
        }
    }
}
