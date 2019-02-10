using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; // needed for Regex

namespace a02 {
    class ItMath {
        public static bool Date(string line) {
            if (Regex.IsMatch(line, @"[0-3][0-9]\.[0-1][0-9]*\.[0-1]([0-9]){3}")) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
