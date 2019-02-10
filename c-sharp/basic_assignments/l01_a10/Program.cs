using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10 {
    class Program {
        static void Main(string[] args) {
            int[] array = {1, 2, 33, 44, 55, 68, 77, 96, 100 };
            int length = array.Length;

            for(int i = 0;i < length;i++) {
                if (array[i] % 2 == 0) {
                    Console.WriteLine(array[i] + " HEP!");
                } else { Console.WriteLine(array[i]); }
            }
        }
    }
}
