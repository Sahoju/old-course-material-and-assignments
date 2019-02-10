using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w05 {
    class Program {
        static void Main(string[] args) {
            while(true) {
                Console.WriteLine("Give us your holy scripture!");
                string line = Console.ReadLine();
                Console.Write("Thy scripture is ");
                Console.Write(TestiPeti.OrNotToBe(line) + "!\n");
            }
        }
    }
}
