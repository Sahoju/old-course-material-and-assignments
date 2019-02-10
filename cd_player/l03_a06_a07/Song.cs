using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l03_a06_a07 {
    class Song {
        public string name;
        public double length;
        public string[] songWriters;

        public string Name {
            get { return name; }
        }
        public double Length {
            get { return length; }
        }
        public string[] SongWriters {
            get { return songWriters; }
        }

    }
}
