using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a03 {
    class Program {
        static void Main(string[] args) {
            Tank tank = new Tank();
            Console.WriteLine("Awwriight! Let's get this frikken' tank rollin'!");
            Console.WriteLine("All tanks need a frikken' name! What shall we call it?");
            tank.Name = Console.ReadLine();

            Console.WriteLine("\n" + tank.Name + ", huh? Frikken' sweetass!");
            Console.WriteLine("Now, how many dudes do you want in there?");
            string line = Console.ReadLine();
            if(int.TryParse(line, out int crewCount)) {
                tank.CrewCount = crewCount;
            }

            Console.WriteLine("But, uhh, cap'n... I've got to admit I have no frikken' idea what type of a tank this is! Wanna enlighten this fool?");
            tank.Type = Console.ReadLine();

            Console.Clear();
            float spd = 0;
            Console.WriteLine("Alright, LET'S GO LET'S GO LET'S GO!!");
            while(true) {
                Console.WriteLine("1. Accelerate");
                Console.WriteLine("2. Decelerate");
                Console.WriteLine("3. Status");
                Console.WriteLine("4. Quit");
                line = Console.ReadLine();
                if (int.TryParse(line, out int choice)) {
                    switch(choice) {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Faster, faster!");
                            spd = tank.AccelerateTo(spd);
                            Console.WriteLine("We're goin' at " + spd + "!");
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Slow down, driver!");
                            spd = tank.SlowTo(spd);
                            Console.WriteLine("We're goin' at " + spd + "!");
                            break;
                        case 3:
                            Console.Clear();
                            tank.Status();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("There is no backing out at this point! TO VALHALLAAAA!!");
                            break;
                    }
                }
            }
        }
    }
}
