using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l03_a06_a07 {
    class CD {
        public string artist = "Solar Fields";
        public string name = "Movements";
        public string genre = "Downtempo";
        public double price = 7.00;
        public string[] songlist = new string[] {
            "Sol" ,
            "Circles of Motion",
            "Discovering",
            "Sky Trees",
            "The Stones are Not Too Busy",
            "Dust",
            "Das Bungalow",
            "Feelings (Album Edit)",
            "Patterns",
            "The Road to Nothingness",
            "Breeze"
        };

        public string Artist {
            get { return artist; }
        }
        public string Name {
            get { return name; }
        }
        public string Genre {
            get { return genre; }
        }
        public double Price {
            get { return price; }
        }
        public string[] Songlist {
            get { return songlist; }
        }

        public void GetSong(int nowplaying) {
            Console.Write(songlist[nowplaying] + "\n");
        }
    }
}
