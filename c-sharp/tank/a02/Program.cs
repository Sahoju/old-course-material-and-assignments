using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02 {
    class Program {
        static void Main(string[] args) {
            Elevator elevator = new Elevator();
            Console.WriteLine("Welcome to Dynamo's elevator!");
            while(true) {
                Console.WriteLine("\nYou are now on floor number " + elevator.Floor);
                Console.WriteLine("Which floor do you want to go to? Type exit to exit the elevator.");
                string line = Console.ReadLine();
                if (int.TryParse(line, out int floor)) {
                    Console.Clear();
                    elevator.Floor = floor;
                }
                else if (line == "exit") {
                    Console.WriteLine("Hyvää päivänjatkoa!");
                    break;
                }
            }
        }
    }
}
