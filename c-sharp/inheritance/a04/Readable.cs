using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a04 {
    class Readable : Item{
        public int Pages { get; set; }
        public string Publisher { get; set; }
        public string Material { get; set; }
        public int ReleaseYear { get; set; }

        public Readable() {}

        public Readable(string name, string type, int pages, string publisher, string material) : base(name, type) {
            Name = name;
            Type = type;
            Pages = pages;
            Publisher = publisher;
            Material = material;
        }
    }
}
