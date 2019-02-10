using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02 {
    class Program {
        static void Main(string[] args) {
            Bicycle jopo = new Bicycle();
            Bicycle tunturi = new Bicycle();
            Boat suvi = new Boat();
            Boat yamaha = new Boat();

            jopo.Name = "Jopo";
            jopo.Model = "Street Model";
            jopo.ModelYear = 2016;
            jopo.Color = "Blue";
            jopo.Gears = false;
            jopo.GearName = "help i can't think of my own instances help";

            tunturi.Name = "Tunturi";
            tunturi.Model = "StreetPower";
            tunturi.ModelYear = 2010;
            tunturi.Color = "Black";
            tunturi.Gears = true;
            tunturi.GearName = "Shimano";

            suvi.Name = "Suvi";
            suvi.Model = "S900";
            suvi.ModelYear = 1990;
            suvi.Color = "White";
            suvi.SeatCount = 3;
            suvi.BoatType = "Rowboat";

            yamaha.Name = "Yamaha";
            yamaha.Model = "Model 1000";
            yamaha.ModelYear = 2010;
            yamaha.Color = "Yellow";
            yamaha.SeatCount = 5;
            yamaha.BoatType = "Motorboat";

            Console.WriteLine("Bicycle 1 info:");
            Console.WriteLine("    Name: " + jopo.Name);
            Console.WriteLine("    Model: " + jopo.Model);
            Console.WriteLine("    ModelYear: " + jopo.ModelYear);
            Console.WriteLine("    Color: " + jopo.Color);
            Console.WriteLine("    Gears: " + jopo.Gears);
            Console.WriteLine("    Gear Name: " + jopo.GearName + "\n");

            Console.WriteLine("Bicycle 2 info:");
            Console.WriteLine("    Name: " + tunturi.Name);
            Console.WriteLine("    Model: " + tunturi.Model);
            Console.WriteLine("    ModelYear: " + tunturi.ModelYear);
            Console.WriteLine("    Color: " + tunturi.Color);
            Console.WriteLine("    Gears: " + tunturi.Gears);
            Console.WriteLine("    Gear Name: " + tunturi.GearName + "\n");

            Console.WriteLine("Boat 1 info:");
            Console.WriteLine("    Name: " + suvi.Name);
            Console.WriteLine("    Model: " + suvi.Model);
            Console.WriteLine("    ModelYear: " + suvi.ModelYear);
            Console.WriteLine("    Color: " + suvi.Color);
            Console.WriteLine("    Seat Count: " + suvi.SeatCount);
            Console.WriteLine("    Boat Type: " + suvi.BoatType + "\n");

            Console.WriteLine("Boat 2 info:");
            Console.WriteLine("    Name: " + yamaha.Name);
            Console.WriteLine("    Model: " + yamaha.Model);
            Console.WriteLine("    ModelYear: " + yamaha.ModelYear);
            Console.WriteLine("    Color: " + yamaha.Color);
            Console.WriteLine("    Seat Count: " + yamaha.SeatCount);
            Console.WriteLine("    Boat Type: " + yamaha.BoatType + "\n");
        }
    }
}
