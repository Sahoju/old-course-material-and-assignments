using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a03 {
    class Program {
        static void Main(string[] args) {
            Radio radio = new Radio();
            Console.WriteLine("The radio is off. Turn it on? y/n");
            string line = Console.ReadLine();
            if (line == "n") {
                Console.WriteLine("You push the power button to turn it off, but because it was already turned off you accidentally turn it on. Life's a bitch.\n");
            }
            else if (line != "y" || line != "n") {
                Console.WriteLine("Try as you might, radio is still off. You ought to turn it on or something.");
                line = Console.ReadLine();
                if (line != "y" || line != "n") {
                    Console.WriteLine("Fine, fine, I'll do it for you, you smartass.\n");
                }
            }
            while(true) {
                Console.WriteLine("What shall you do with the radio?");
                Console.WriteLine("1. Set volume");
                Console.WriteLine("2. Set frequency");
                Console.WriteLine("3. Turn off");
                if (line != "y") {
                    Console.WriteLine("4. Cry over the unfairness of this program");
                }
                string line2 = Console.ReadLine();
                if (Int32.TryParse(line2, out int choice)) {
                    switch (choice) {
                        case 1:
                            Console.WriteLine("Give a volume from 1 to 10:");
                            line2 = Console.ReadLine();
                            if (Int32.TryParse(line2, out int volume)) {
                                radio.Volume = volume;
                                break;
                            }
                            else {
                                Console.WriteLine("Stuff broke. Don't know why.\n");
                                break;
                            }
                        case 2:
                            Console.WriteLine("Give a frequency from 2000.0 to 26000.0");
                            line2 = Console.ReadLine();
                            if (float.TryParse(line2, out float frequency)) {
                                radio.Frequency = frequency;
                                break;
                            } else {
                                Console.WriteLine("Stuff broke. Don't know why.\n");
                                break;
                            }
                        case 3:
                            Console.WriteLine("Radio turned off. A nice day was had.");
                            break;
                        default:
                            break;
                    }
                    if (choice == 3) {
                            break;
                    }
                }
            }
        }
    }
}
