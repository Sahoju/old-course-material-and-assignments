using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace a03 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Be ignorant and put numbers with nothing but a comma in between each number");
            ItParser.TestParser(Console.ReadLine());
        }
    }
}
