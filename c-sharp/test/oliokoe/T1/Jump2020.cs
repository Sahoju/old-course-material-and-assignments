using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1 {
    class Jump2020 {
        List<JumpResult> results = new List<JumpResult>();

        public List<JumpResult> Results {
            get {
                return results;
            }
            set {
                results = value;
            }
        }


        public List<JumpResult> PrintAlpha(List<JumpResult> resultsAll) {
            resultsAll.Sort();
            return results;
        }
    }
}
