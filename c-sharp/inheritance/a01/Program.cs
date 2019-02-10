using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l07 {
    class Program {
        static void Main(string[] args) {
            Employee kirsi = new Employee();
            Boss jussi = new Boss();

            kirsi.Name = "Kirsi Kernel";
            kirsi.Profession = "Teacher";
            kirsi.Salary = 1200;

            jussi.Name = "Jussi Jurkka";
            jussi.Profession = "Head of Institute";
            jussi.Salary = 9000;
            jussi.Car = "Audi";
            jussi.Bonus = 5000;

            Console.WriteLine("Employee:");
            Console.WriteLine("    Name: " + kirsi.Name);
            Console.WriteLine("    Profession: " + kirsi.Profession);
            Console.WriteLine("    Salary: " + kirsi.Salary + "\n");

            Console.WriteLine("Boss:");
            Console.WriteLine("    Name: " + jussi.Name);
            Console.WriteLine("    Profession: " + jussi.Profession);
            Console.WriteLine("    Salary: " + jussi.Salary);
            Console.WriteLine("    Car: " + jussi.Car);
            Console.WriteLine("    Bonus: " + jussi.Bonus + "\n");

            kirsi.Salary = 2200;

            Console.WriteLine("Employee:");
            Console.WriteLine("    Name: " + kirsi.Name);
            Console.WriteLine("    Profession: " + kirsi.Profession);
            Console.WriteLine("    Salary: " + kirsi.Salary + "\n");
        }
    }
}
