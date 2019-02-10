using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w05 {
    class TestiPeti {
        private static int intnum;
        private static float floatnum;

        public static bool OrNotToBe(string line) {
            if (int.TryParse(line, out intnum)) {
                return true;
            }
            else if (line.Contains(",")) { // checks if the float has a comma
                var firstIndex = line.IndexOf(",");
                var result = firstIndex != line.LastIndexOf(",") && firstIndex != -1; // checks if there are more than one commas... somehow
                if (result == true) {
                    return false;
                }
                if (float.TryParse(line, out floatnum)) {
                    return true;
                }
                return false; // C# for some reason doesn't allow no return value here
            }
            else if (line.Contains(".")) {
                return false;
            }
            else {
                return false;
            }
        }
    }
}
