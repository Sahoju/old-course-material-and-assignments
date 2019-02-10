using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a01 {
    class Program {
        static void Main(string[] args) {
            Vehicle porsche = new Vehicle();
            Vehicle ducati = new Vehicle();
            porsche.Name = "Porsche";
            porsche.Model = "911";
            ducati.Name = "Ducati";
            ducati.Model = "Diavel";
            Tire tire1 = new Tire("Nokia", "Hakkapeliitta", "205R16");
            Tire tire2 = new Tire("MIC", "Pilot", "160R17");
            Tire tire3 = new Tire("MIC", "Pilot", "140R16");

            for(int i = 0; i < 4; i++) {
                porsche.Tires.Add(tire1);
                Console.WriteLine("Added tire to Porsche");
            }
            ducati.Tires.Add(tire2);
            Console.WriteLine("Added tire to Ducati");
            ducati.Tires.Add(tire3);
            Console.WriteLine("Added tire to Ducati\n");

            Console.WriteLine("Name & model: " + porsche.Name + " " + porsche.Model);
            for(int i = 0; i < 4; i++) {
                Console.WriteLine("    Tire: " + porsche.Tires[i].Name + " " + porsche.Tires[i].Model + " " + porsche.Tires[i].Size);
            }

            Console.WriteLine("\nName & model: " + ducati.Name + " " + ducati.Model);
            Console.WriteLine("    Tire: " + ducati.Tires[0].Name + " " + ducati.Tires[0].Model + " " + ducati.Tires[0].Size);
            Console.WriteLine("    Tire: " + ducati.Tires[1].Name + " " + ducati.Tires[1].Model + " " + ducati.Tires[1].Size + "\n");
        }
    }
}
