using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l02_a08 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Type a word: ");
            string line = Console.ReadLine();
            line = line.Replace(" ", "");
            int palindrome = 1;
            
            int length = line.Length;
            if (length % 2 == 0) {
                Console.WriteLine("It's not a palindrome.");
                palindrome = 0;
            } else {
                length = length / 2 + 1;
                int j = length - 2;
                for (int i = length; j >= 0; i++, j--) {
                    if (line[i] != line[j]) {
                        Console.WriteLine("It's not a palindrome.");
                        palindrome = 0;
                        break;
                    }
                }

                if (palindrome == 1) {
                    Console.WriteLine("It's a palindrome! Holy crap!");
                }
            }
        }
    }
}
