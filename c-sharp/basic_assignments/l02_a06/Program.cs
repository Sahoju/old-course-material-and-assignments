using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l02_a06 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int num = rand.Next(0, 100);
            int guess = 150;
            int guess_count = 0;

            while (guess != num) {
                Console.WriteLine("Guess a number between 0 and 100: ");
                string line = Console.ReadLine();
                if (int.TryParse(line, out guess)) {
                    if (guess == num) {
                        Console.WriteLine("You guessed it! Nice job. It took you " + guess_count + " tries.");
                    } else if (guess < num) {
                        Console.WriteLine("The number is larger than that.");
                        guess_count++;
                    } else if (guess > num) {
                        Console.WriteLine("The number is smaller than that.");
                        guess_count++;
                    }
                }
            }
        }
    }
}
