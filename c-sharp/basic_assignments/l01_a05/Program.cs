// Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina.Aikamääre sekuntteina kysytään käyttäjältä.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a05 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Give seconds: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int sec)) {
                int hrs = sec / 3600;
                sec -= 3600 * hrs;
                int min = sec / 60;
                sec -= 60 * min;
                Console.WriteLine(hrs + " hours, " + min + " minutes and " + sec + " seconds.\nWait a minute, I wanted seconds of this food!");
            }
        }
    }
}
