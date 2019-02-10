// Odottamani pisteet 7/7p
// Kaikki toimii vaaditusti.
// En ole satavarma koodin laadusta, mutta se kuitenkin tekee mitä pyydettiin.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1 {
    class Program {
        static void Main(string[] args) {
            Jump2020 jump2020 = new Jump2020();

            jump2020.Results.Add(JumpResult.AddResult("Matti", 12.10));
            jump2020.Results.Add(JumpResult.AddResult("Minna", 10.11));
            jump2020.Results.Add(JumpResult.AddResult("Keijo", 14.34));
            jump2020.Results.Add(JumpResult.AddResult("Carita", 8.2));
            jump2020.Results.Add(JumpResult.AddResult("Pirjo", 14.65));
            jump2020.Results.Add(JumpResult.AddResult("Kaisa", 21.43));
            jump2020.Results.Add(JumpResult.AddResult("James", 8.54));
            jump2020.Results.Add(JumpResult.AddResult("Seppo", 18.24));

            Console.WriteLine("***************************");
            Console.WriteLine("Jump2020 booted");
            Console.WriteLine("***************************");

            for (int i = 0; i < jump2020.Results.Count; i++) {
                Console.WriteLine("Added {0}, distance {1}", jump2020.Results[i].Name, jump2020.Results[i].Result);
            }

            var sorted = jump2020.Results.OrderBy(x => x.Name).ToList();
            Console.WriteLine("\n***************************");
            Console.WriteLine("Results");
            Console.WriteLine("***************************");
            
            foreach(JumpResult jumpResult in sorted) {
                Console.WriteLine("{0} : {1}", jumpResult.Name, jumpResult.Result);
            }
            Console.WriteLine("{0} jumps in total", sorted.Count);
            double average = sorted.Average(x => x.Result);
            Console.WriteLine("Average distance is {0}", average);
        }
    }
}
/*

Console prints:

***************************
Jump2020 booted
***************************
Added Matti, distance 12,1
Added Minna, distance 10,11
Added Keijo, distance 14,34
Added Carita, distance 8,2
Added Pirjo, distance 14,65
Added Kaisa, distance 21,43
Added James, distance 8,54
Added Seppo, distance 18,24

***************************
Results
***************************
Carita : 8,2
James : 8,54
Kaisa : 21,43
Keijo : 14,34
Matti : 12,1
Minna : 10,11
Pirjo : 14,65
Seppo : 18,24
8 jumps in total
Average distance is 13,45125

*/