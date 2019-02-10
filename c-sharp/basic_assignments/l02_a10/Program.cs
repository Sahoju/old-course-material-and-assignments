using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l02_a10 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("This program generates a + and - calculation for you to solve.");
            Console.WriteLine("Give the amount of numbers you want in the calculation: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int amount)) {
                int[] num = new int[amount];
                int[] operation = new int[amount-1];
                Random rand = new Random();

                // Generating random numbers
                for (int i = num.Length - 1; i >= 0; i--) {
                    num[i] = rand.Next(0, 19);
                    switch (num[i]) {
                        case 16:
                            num[i] = 20;
                            break;
                        case 17:
                            num[i] = 30;
                            break;
                        case 18:
                            num[i] = 50;
                            break;
                        case 19:
                            num[i] = 100;
                            break;
                    }
                }

                // Generating random calculations
                for (int i = operation.Length - 1; i >= 0; i--) {
                    operation[i] = rand.Next(0, 2);
                }

                // Writing the calculation for the user
                for (int i = 0; i <= num.Length; i++) {
                    Console.Write(num[i] + " ");
                    if (i == num.Length - 1) {
                        break;
                    }
                    switch (operation[i]) {
                        case 0:
                            Console.Write("- ");
                            break;
                        case 1:
                            Console.Write("+ ");
                            break;
                    }
                }
                Console.Write("\n\n");
                int answer = num[0];

                // Getting the right answer from the calculation
                for (int i = 0; i <= operation.Length - 1; i++) {
                    switch (operation[i]) {
                        case 0:
                            answer -= num[i + 1];
                            break;
                        case 1:
                            answer += num[i + 1];
                            break;
                    }
                }

                // Asking the user for the answer and comparing it to the correct answer
                Console.WriteLine("Give the answer: ");
                line = Console.ReadLine();
                if (int.TryParse(line, out int guess)) {
                    if (guess == answer) {
                        Console.WriteLine("Correct!");
                    } else {
                        Console.WriteLine("Wrong! Correct answer was " + answer);
                    }
                }
            }
        }
    }
}
