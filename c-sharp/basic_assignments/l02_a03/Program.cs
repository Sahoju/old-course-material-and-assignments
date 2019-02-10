using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l02_a03 {
    class Program {
        static void Main(string[] args) {
            int[] pts = new int[5];
            int smallest = -1;
            int largest = -1;
            int sum = 0;

            Console.WriteLine("Give points: ");
            for (int i = 0; i < 5; i++) {
                string line = Console.ReadLine();
                if (int.TryParse(line, out pts[i])) {
                    for (int j = i-1; j >= 0; j--) {
                        if (i == 0) { break; }
                        if (i < j) { smallest = i; }
                        if (i > j) { largest = i; }
                    }
                }
            }

            if (smallest == -1) { smallest = 0; }
            if (largest == -1) { largest = 0; }

            for (int i = 0; i < 5; i++) {
                sum += pts[i];
            }
            sum -= pts[largest] + pts[smallest];
            Console.WriteLine("Sum: " + sum);
        }
    }
}
