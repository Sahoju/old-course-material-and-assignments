using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02 {
    class Program {
        static void Main(string[] args) {
            Fridge rosenlew = new Fridge();
            Shelf doorShelf = new Shelf(15000);
            Shelf shelf1 = new Shelf(50000);
            Shelf shelf2 = new Shelf(50000);
            Shelf shelf3 = new Shelf(50000);
            Liquid yogurt = new Liquid(2500, "Valio Yogurt");
            Liquid ketchup = new Liquid(672, "Heinz Ketchup");
            Edible lihis = new Edible(576, "Lidl Lihapiirakka");
            Edible pizza = new Edible(4500, "Café Pineto Kanapizza");

            rosenlew.Manufacturer = "Rosenlew";
            rosenlew.Model = "RJKL3300";

            for(int i = 0; i < 4; i++) {
                shelf1.Edibles.Add(lihis);
                if(i < 3) {
                    doorShelf.Liquids.Add(yogurt);
                }
            }
            doorShelf.Liquids.Add(ketchup);
            shelf2.Edibles.Add(pizza);

            rosenlew.Shelves.Add(doorShelf);
            rosenlew.Shelves.Add(shelf1);
            rosenlew.Shelves.Add(shelf2);

            Console.WriteLine(rosenlew.Manufacturer + " " + rosenlew.Model);
            Console.WriteLine("    " + rosenlew.Shelves[0] + " contains:");
            for(int i = 0; i < 4; i++) {
                Console.WriteLine("        " + rosenlew.Shelves[0].Liquids[i].Type);
            }
            Console.WriteLine("    " + rosenlew.Shelves[1] + " contains:");
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("        " + rosenlew.Shelves[1].Edibles[i].Type);
            }
            Console.WriteLine("    " + rosenlew.Shelves[2] + " contains:");
            Console.WriteLine("        " + rosenlew.Shelves[2].Edibles[0].Type);
        }
    }
}
