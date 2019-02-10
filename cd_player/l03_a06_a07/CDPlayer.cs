using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;

namespace l03_a06_a07 {
    class CDPlayer {
        public bool power = false;
        public bool cdIsIn = false;
        public double currentpos = 0.00;
        public static int[] time = new int[2] { 0, 0 };

        public bool PowerButton {
            get {
                return power;
            }
            set {
                power = value;
            }
        }
        public bool CDTray { get; set; }
        public bool EjectButton { get; set; }
        public bool PlayButton { get; set; }
        public bool StopButton { get; set; }
        public bool NextButton { get; set; }
        public bool PreviousButton { get; set; }
        public int[] SongCurrentPos {
            get {
                return time;
            }
        }
        public int CurrentSong { get; set; }

        public void PowerToggle() {
            if (power == true) { power = false; }
            else { power = true; }
        }

        public void EjectCD() {
            if (cdIsIn == true) { cdIsIn = false; }
        }

        public void ReadCD(CD cd) {
            Console.WriteLine("Artist: " + cd.Artist);
            Console.WriteLine("Album name: " + cd.Name);
            Console.WriteLine("Genre(s): " + cd.Genre);
            Console.WriteLine("Price: " + cd.Price + " e");
            Console.WriteLine("Songs: ");
            int max = cd.songlist.Length;
            for (int i = 0; i < max; i++) {
                Console.WriteLine("    " + (i + 1) + ". " + cd.Songlist[i]);
            }
        }

        public static void Play(object source, ElapsedEventArgs e) {
            time[1] += 1;
            if (time[1] == 60) {
                time[0] += 1;
                time[1] = 0;
            }
        }

        public void Stop() {
            time[1] = 0;
            time[0] = 0;
        }
    }
}
