using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a04 {
    class Program {
        static void Main(string[] args) {
            Manga conan = new Manga(); // instance of Manga -> Book -> Readable -> Item
            Laptop asus = new Laptop(); // instance of Laptop -> Computer -> Machine -> Item
            Magazine playboy = new Magazine(); // instance of Readable -> Item
            GameConsole ps4 = new GameConsole(); // instance of Machine -> Item

            conan.Name = "Detective Conan"; //
            conan.Type = "Manga";           // from Item
            conan.Pages = 187;                          //
            conan.Publisher = "Punainen Jättiläinen";   //
            conan.Material = "Paperback";               //
            conan.ReleaseYear = 1999;                   // from Readable
            conan.Author = "Gosho Aoyama";      //
            conan.Series = "Detective Conan";   // from Book
            conan.Volume = 10;  // from Manga

            asus.Name = "Asus";     // 
            asus.Type = "Laptop";   // from Item
            asus.Model = "???";     //
            asus.Voltage = 240;     // from Machine
            asus.GFX = "???";               //
            asus.CPU = "Intel i5";          //
            asus.RAM = 8;                   //
            asus.Motherboard = "???";       //
            asus.PowerSupply = "???";       // from Computer
            asus.UsedFor = "School stuff";  //
            asus.WillItBend = false;        // from Laptop

            Console.WriteLine("Manga: ");
            Console.WriteLine("    Name: " + conan.Name);
            Console.WriteLine("    Type: " + conan.Type);
            Console.WriteLine("    Pages: " + conan.Pages);
            Console.WriteLine("    Publisher: " + conan.Publisher);
            Console.WriteLine("    Material: " + conan.Material);
            Console.WriteLine("    ReleaseYear: " + conan.ReleaseYear);
            Console.WriteLine("    Author: " + conan.Author);
            Console.WriteLine("    Series: " + conan.Series);
            Console.WriteLine("    Volume: " + conan.Volume + "\n");

            Console.WriteLine("Laptop:");
            Console.WriteLine("    Name: " + asus.Name);
            Console.WriteLine("    Type: " + asus.Type);
            Console.WriteLine("    Model: " + asus.Model);
            Console.WriteLine("    Voltage: " + asus.Voltage);
            Console.WriteLine("    GFX: " + asus.GFX);
            Console.WriteLine("    CPU: " + asus.CPU);
            Console.WriteLine("    RAM: " + asus.RAM);
            Console.WriteLine("    Motherboard: " + asus.Motherboard);
            Console.WriteLine("    PowerSupply: " + asus.PowerSupply);
            Console.WriteLine("    UsedFor: " + asus.UsedFor);
            Console.WriteLine("    WillItBend: " + asus.WillItBend);
        }
    }
}
