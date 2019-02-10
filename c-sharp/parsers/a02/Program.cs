using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02 {
    class Program {
        static void Main(string[] args) {
            while(true) {
                Console.WriteLine("To prove your Suominess, give the date in Suomi Finland Perkele format! That's dd.mm.yy(yy)!");
                string line = Console.ReadLine();
                Console.Write("You are a " + ItMath.Date(line) + " Finnish citizen!!!\n");

            }
        }
    }
}
