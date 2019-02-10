using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l03 {
    class Program {
        static void Main(string[] args) {
            Class_test test = new Class_test("opel");
            test.Model = "mercedes";
            test.Color = "brown";
            Console.WriteLine(test.speed);

            test[0] = "Hello!";
            test[99] = "Last string";
        }
    }
}
