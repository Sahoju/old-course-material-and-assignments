using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a03 {
    class Tank {
        public string name;
        public string type;
        public int crewCount;
        private float speed = 0;
        private static float speedMax = 100;

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public string Type {
            get {
                return type;
            }
            set {
                type = value;
            }
        }
        public int CrewCount {
            get {
                return crewCount;
            }
            set {
                if (value > 6) {
                    Console.WriteLine("\nIt's frikken' crowded in here! I'm gettin' out.");
                    crewCount = 6;
                }
                else if (value == 1) {
                    Console.WriteLine("\nI can't frikken' control this alone, man! I'm gettin' my best bud here.");
                    crewCount = 2;
                }
                else if (value == 0) {
                    Console.WriteLine("\nThere's frikken' no one to control this thing! Let's just get two guys.");
                    crewCount = 2;
                }
                else {
                    Console.WriteLine("Frikken' peachy!");
                    crewCount = value;
                }
            }
        }
        public float Speed {
            get {
                return speed;
            }
        }
        public float SpeedMax {
            get {
                return speedMax;
            }
        }

        public float AccelerateTo(float spd) {
            if (spd + 5 > 100) {
                Console.WriteLine("This frikken' thing can't go that fast!");
                return spd;
            }
            return spd += 5;
        }
        public float SlowTo(float spd) {
            if (spd - 5 < 0) {
                Console.WriteLine("We ain't frikken' going back! TO VALHALLAAAAAA!");
                return spd;
            }
            return spd -= 5;
        }

        public void Status() {
            Console.WriteLine("Tank name: " + name);
            Console.WriteLine("Tank type: " + type);
            Console.WriteLine("Crew count: " + crewCount);
            Console.WriteLine("Speed: " + speed);
        }
    }
}
