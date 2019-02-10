// Tee ohjelma, joka tulostaa kuusen. Kysy käyttäjältä puunkorkeus.
// Käytä juurena kaksi korkeuden yksikköä.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l02_a05 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Give the height of an evergreen: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int height)) {
                int max_height = height;
                for (int row = 0; height > 0; height--, row++) {
                    if (height <= 2) {
                        for (int spaces = max_height - 3; spaces > 0; spaces--) { // 3 = -2 from the root of the tree, -1 for getting the stair effect
                            Console.Write(" ");
                        }
                        Console.Write("*\n");
                        continue;
                    }
                    for (int spaces = height - 3; spaces > 0; spaces--) {
                        Console.Write(" ");
                    }
                    for (int stars = row * 2 + 1; stars > 0; stars--) {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
