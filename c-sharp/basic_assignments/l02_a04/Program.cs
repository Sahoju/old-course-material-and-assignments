// Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5
// ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon).
// Tulosta arvosanajakauma käyttäen tähtimerkkejä

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l02_a04 {
    class Program {
        static void Main(string[] args) {
            int zero = 0;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int grade = 0;

            Console.WriteLine("Give gradings for students from 0 to 5. Stop by typing -1. ");
            while (grade != -1) {
                string line = Console.ReadLine();
                if(int.TryParse(line, out grade)) {
                    switch (grade) {
                        case 0: zero++; break;
                        case 1: one++; break;
                        case 2: two++; break;
                        case 3: three++; break;
                        case 4: four++; break;
                        case 5: five++; break;
                        default: break;
                    }
                }
            }

            Console.Write("\n0: ");
            for (int i = zero; i > 0; i--) {
                Console.Write("*");
            }
            Console.Write("\n1: ");
            for (int i = one; i > 0; i--) {
                Console.Write("*");
            }
            Console.Write("\n2: ");
            for (int i = two; i > 0; i--) {
                Console.Write("*");
            }
            Console.Write("\n3: ");
            for (int i = three; i > 0; i--) {
                Console.Write("*");
            }
            Console.Write("\n4: ");
            for (int i = four; i > 0; i--) {
                Console.Write("*");
            }
            Console.Write("\n5: ");
            for (int i = five; i > 0; i--) {
                Console.Write("*");
            }

            Console.Write("\n");
        }
    }
}
