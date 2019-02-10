using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l02_a07 {
    class Program {
        static void Main(string[] args) {
            int[] array1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] array2 = new int[5] { 5, 15, 25, 35, 45 };
            int[] array3 = new int[10];
            Console.Write("Numbers in array 1: ");
            for (int i = 0; i < 5; i++) {
                if (i == 4) {
                    Console.Write(array1[i]);
                    break;
                }
                Console.Write(array1[i] + ", ");
            }
            Console.Write("\nNumbers in array 2: ");
            for (int i = 0; i < 5; i++) {
                if (i == 4) {
                    Console.Write(array2[i]);
                    break;
                }
                Console.Write(array2[i] + ", ");
            }

            Array.Copy(array1, 0, array3, 0, 5);
            Array.Copy(array2, 0, array3, 5, 5);
            for (int i = 0; i < 10; i++) {
                for (int j = i; j < 10; j++) {
                    if (array3[j] < array3[i]) {
                        int temp = array3[i];
                        array3[i] = array3[j];
                        array3[j] = temp;
                    }
                }
            }

            Console.Write("\nNumbers in array 3: ");
            for (int i = 0; i < 10; i++) {
                if (i == 9) {
                    Console.Write(array3[i]);
                    break;
                }
                Console.Write(array3[i] + ", ");
            }
            Console.Write("\n");
        }
    }
}
