using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a03 {
    class Team {
        public List<Player> players = new List<Player>();

        public string Name { get; set; }
        public string City { get; set; }
        public List<Player> Players {
            get { return players; }
            set { players = value; }
        }
    }
}
