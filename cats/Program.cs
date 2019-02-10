using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l05 {
    class Program {
        static void Main(string[] args) {
            // MathUtils utils = new MathUtils(); // Can not make instances of static classes
            // int v = utils.Power2(15); // Can not refer to static methods
            int v = MathUtils.Power2(15);
            Console.WriteLine("V: " + v);

            // Cat
            CreateCats(99);
            Console.WriteLine("CatCount: " + Cat.CatCount()); // static class can be referred to without an instance

            // casting
            int i = 54321;
            long n = i;
            byte c = (byte)n;
            Console.WriteLine("n: " + n);
            Console.WriteLine("c: " + c);
            double d = 654321.9987;
            int inte = (int)Math.Round(d);
            Console.WriteLine("inte: " + inte);
            inte = (int)(d + 0.5);
            Console.WriteLine("inte: " + inte);
            inte = Convert.ToInt32(d);
            Console.WriteLine("inte: " + inte);
            double dou = double.MaxValue;
            Console.WriteLine("dou: " + dou);

            long number = 0;
            string line = Console.ReadLine();
            bool result = Int64.TryParse(line, out number);
            if (result) {
                Console.WriteLine("Success: " + number);
            }
            else {
                Console.WriteLine("NaN!");
            }

        }
        static void CreateCats(int num)
        {
            int i;
            for(i = 0; i < 99; i++) {
                Cat cat = new Cat();
            }
        }
    }
}
