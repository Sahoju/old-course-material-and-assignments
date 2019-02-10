using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Windows.Input;

namespace l03_a06_a07 {
    class Program {
        static void Main(string[] args) {
            CD cd = new CD();
            CDPlayer cdplayer = new CDPlayer();
            int nowplaying = 0;
            
            Timer aTimer = new Timer();
            aTimer.Elapsed += new ElapsedEventHandler(CDPlayer.Play);
            aTimer.Interval = 1000;
            aTimer.Enabled = false;

            if (cdplayer.PowerButton == false) {
                Console.WriteLine("Turn on power? y/n");
                string line = Console.ReadLine();
                if (char.TryParse(line, out char choice)) {
                    if (choice == 'y') {
                        cdplayer.PowerButton = true;
                        Console.Clear();
                    } else {
                        Console.WriteLine("Eh, alright then.");
                    }
                }
            }

            while (cdplayer.PowerButton == true) {
                Console.WriteLine("What will you do with the CD player?");
                Console.Write("1. Play\n" +
                    "2. Pause\n" +
                    "3. Stop\n" +
                    "4. Previous song\n" +
                    "5. Next song\n" +
                    "6. Turn off power\n\n");
                
                string line = Console.ReadLine();
                if (int.TryParse(line, out int choice)) {
                    switch (choice) {
                        case 1:
                            aTimer.Enabled = true;
                            Console.Clear();
                            Console.Write("Started playing from: ");
                            if (cdplayer.SongCurrentPos[0] >= 0 && cdplayer.SongCurrentPos[0] <= 9) { // time[0] == minutes, time[1] == seconds
                                Console.Write("0" + cdplayer.SongCurrentPos[0] + ":");
                            } else { Console.Write(cdplayer.SongCurrentPos[0] + ":"); }
                            if (cdplayer.SongCurrentPos[1] >= 0 && cdplayer.SongCurrentPos[1] <= 9) {
                                Console.Write("0" + cdplayer.SongCurrentPos[1] + "\n");
                            } else { Console.Write(cdplayer.SongCurrentPos[1] + "\n"); }
                            Console.Write("Now playing: ");
                            cd.GetSong(nowplaying);
                            break;

                        case 2:
                            aTimer.Enabled = false;
                            Console.Clear();
                            Console.Write("Paused at: ");
                            if (cdplayer.SongCurrentPos[0] >= 0 && cdplayer.SongCurrentPos[0] <= 9) { // time[0] == minutes, time[1] == seconds
                                Console.Write("0" + cdplayer.SongCurrentPos[0] + ":");
                            } else { Console.Write(cdplayer.SongCurrentPos[0] + ":"); }
                            if (cdplayer.SongCurrentPos[1] >= 0 && cdplayer.SongCurrentPos[1] <= 9) {
                                Console.Write("0" + cdplayer.SongCurrentPos[1] + "\n");
                            } else { Console.Write(cdplayer.SongCurrentPos[1] + "\n"); }
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Stopped the song");
                            cdplayer.Stop();
                            break;

                        case 4:
                            Console.Clear();
                            cdplayer.SongCurrentPos[0] = 0;
                            cdplayer.SongCurrentPos[1] = 0;
                            nowplaying -= 1;
                            if (nowplaying < 0) {
                                Console.WriteLine("You are at the first song; can not go further back");
                                nowplaying = 0;
                            } else {
                                Console.WriteLine("Went to the previous song");
                            }
                            break;
                        case 5:
                            Console.Clear();
                            cdplayer.SongCurrentPos[0] = 0;
                            cdplayer.SongCurrentPos[1] = 0;
                            nowplaying += 1;
                            if (nowplaying > 11) {
                                Console.WriteLine("You are at the last song; can not go further forward");
                                nowplaying = 11;
                            } else {
                                Console.WriteLine("Went to the next song");
                            }
                            break;
                        case 6:
                            Console.Clear();
                            cdplayer.PowerButton = false;
                            Console.WriteLine("See ya!");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("What the heck?");
                            break;
                    }
                }
            }
        }
    }
}
