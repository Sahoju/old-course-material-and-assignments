// Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa puolikuusen

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l02_a01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Give the amount of rows: ");
            string line = Console.ReadLine();
            Console.Write("\n");
            if(int.TryParse(line, out int rows)) {
                for(int i = 1; rows > 0; rows--, i++) {
                    for(int j = i; j > 0; j--) {
                        Console.Write("*"); // Console.Write does not include EOL
                    }
                    Console.Write("\n");
                }
            }
            Console.Write("\n");
        }
    }
}
