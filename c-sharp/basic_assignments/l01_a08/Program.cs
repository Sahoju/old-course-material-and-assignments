// Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a08 {
    class Program {
        static void Main(string[] args) {
            const int turns = 3;
            double[] num = new double[turns];
            Console.WriteLine("Give three numbers: ");
            
            for (int i = 0;i < turns;i++) {
                string line = Console.ReadLine();
                if (double.TryParse(line, out double temp)) {
                    num[i] = temp;
                }
            }

            if (num[0] > num[1] && num[1] > num[2]) {
                Console.WriteLine(num[0] + " " + num[1] + " " + num[2]);
            }
            else if (num[2] > num[1] && num[0] > num[2]) {
                Console.WriteLine(num[0] + " " + num[2] + " " + num[1]);
            }
            else if (num[0] < num[1] && num[0] > num[2]) {
                Console.WriteLine(num[1] + " " + num[0] + " " + num[2]);
            }
            else if (num[2] > num[0] && num[1] > num[2]) {
                Console.WriteLine(num[1] + " " + num[2] + " " + num[0]);
            }
            else if (num[0] < num[1] && num[1] < num[2]) {
                Console.WriteLine(num[2] + " " + num[1] + " " + num[0]);
            }
            else if (num[2] > num[0] && num[0] > num[1]) {
                Console.WriteLine(num[2] + " " + num[0] + " " + num[1]);
            }
        }
    }
}
