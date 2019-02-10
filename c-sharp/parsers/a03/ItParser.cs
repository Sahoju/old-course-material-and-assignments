using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; // needed for Regex

namespace a03 {
    class ItParser {
        private static void Count(int[] theworld) {
            Console.WriteLine("The string had " + theworld.Length + " numbers in it.");
        }
        private static void Sum(int[] theworld) {
            int sum = theworld.Sum();
            Console.WriteLine("Adding all the string's numbers together, you get " + sum + ".");
        }
        private static void Average(int[] theworld) {
            double avg = theworld.Average();
            Console.WriteLine("The average of the string's numbers is " + avg + ".");
        }
        public static void TestParser(string line) {
            string pattern = ",";
            string[] substrings = Regex.Split(line, pattern); // trimmed string will become an array because of the removed commas
            int[] num = new int[substrings.Length];
            for(int i = 0; i < substrings.Length; i++) {
                num[i] = Int32.Parse(substrings[i]);
            }
            Count(num);
            Sum(num);
            Average(num);
        }

    }
}
