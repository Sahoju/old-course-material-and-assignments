using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a05 {
    class Program {
        static void Main(string[] args) {
            Human human = new Human();
            human.Age = 666;
            Console.WriteLine("Human is " + human.Age + " years old.");
            human.Move();

            Adult adult = new Adult();
            adult.Age=30;
            adult.Car="Audi";
            Console.WriteLine("Adult is "+adult.Age+" years old, and has an " + adult.Car + ".");
            adult.Move();

            Baby baby = new Baby();
            baby.Age=1;
            baby.Diaper="Datsun";
            Console.WriteLine("Baby is "+baby.Age+" year old, and has a "+baby.Diaper + ".");
            baby.Move();
        }
    }
}
