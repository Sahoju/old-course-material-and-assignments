using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l03 {
    class Class_test {
        public readonly int speed = 10;
        private string model;
        public string Color { get; set; }

        public int Speed { get; set; }

        public void Accelerate() {
            Speed += 5;
        }

        public void Brake() {
            Speed -= 5;
            if(Speed < 0) Speed = 0;
        }

        private string[] strings = new string[100];
        public string this[int i] {
            get {
                if (i >= 0 && i < 100) {
                    return strings[i];
                } else {
                    return "out of bounds";
                }
            }
            set {
                if(i >= 0 && i < 100) {
                    strings[i] = value;
                }
            }
        }


        public string Model {
            get { return model; }
            set {
                if(value != "toyota" && speed < 10) {
                    model = "there is no others than toyota and nissan";
                } else {
                    model = value;
                }
            }
        }
        
        public Class_test(string model) {
            this.Model = model;
        }
        public Class_test(string model, string color) {
            this.Model = model;
            this.Model = color;
        }

        ~Class_test() {
            Console.WriteLine("Class_test destructor");
        }
    }
}
