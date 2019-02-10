using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a03_true {
    class Program {
        static void Main(string[] args) {
            Amplifier amplifier = new Amplifier();

            Console.WriteLine("You want to listen to music. You turn on the speakers and put on your favorite music.");

            while(true) {
                Console.WriteLine("Volume is set to " + amplifier.Volume);
                Console.WriteLine("How much volume do you want?");
                string line = Console.ReadLine();
                if (int.TryParse(line, out int volume)) {
                    Console.Clear();
                    amplifier.Volume = volume;
                }
            }
        }
    }
}
