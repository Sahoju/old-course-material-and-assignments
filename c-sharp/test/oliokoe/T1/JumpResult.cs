using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1 {
    class JumpResult {
        public string Name { get; set; }
        public double Result { get; set; }

        public JumpResult(string name, double result) {
            Name = name;
            Result = result;
        }

        public static JumpResult AddResult(string name, double result) {
            JumpResult jumpResult = new JumpResult(name, result);
            return jumpResult;
        }
    }
}
