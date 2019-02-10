using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // used for reading from and writing to a text file

namespace a03 {
    class Program {
        static void Main(string[] args) {
            Team team1 = new Team();
            Team team2 = new Team();
            Random rand = new Random();
            string path1 = @"D:\L4929\Players1.txt";
            string path2 = @"D:\L4929\Players2.txt";

            team1.Name = "Basketball";
            team1.City = "Detroit";
            team2.Name = "Soccer";
            team2.City = "Brasília";

            Console.WriteLine("Team " + team1.Name + " from " + team1.City);
            for (int i = 0; i < 25; i++) {
                Player player = new Player();
                team1.Players.Add(player);
                team1.Players[i].FirstName = "Player";
                team1.Players[i].LastName = i.ToString();
                if (i == 0) {
                    team1.Players[i].Position = "mv";
                } else {
                    switch (rand.Next(0, 2)) {
                        case 0:
                            team1.Players[i].Position = "p";
                            break;
                        case 1:
                            team1.Players[i].Position = "h";
                            break;

                    }
                }
                switch (rand.Next(0, 2)) {
                    case 0:
                        team1.Players[i].Handedness = "R";
                        break;
                    case 1:
                        team1.Players[i].Handedness = "L";
                        break;
                }

                Console.Write("    Name: " + team1.Players[i].FirstName + " " + team1.Players[i].LastName + ", ");
                Console.Write("    Position: " + team1.Players[i].Position + ", ");
                Console.WriteLine("    Dominant hand: " + team1.Players[i].Handedness);
                
                // This text is added only once to the file.
                if (!File.Exists(path1)) {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path1)) { }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path1)) {
                    sw.WriteLine(
                        team1.Players[i].FirstName + ":" + team1.Players[i].LastName + ":"
                        + team1.Players[i].Position + ":" + team1.Players[i].Handedness
                    );
                }
            }

                

            Console.WriteLine("\nTeam " + team2.Name + " from " + team2.City);
            for (int i = 0; i < 25; i++) {
                Player player = new Player();
                team2.Players.Add(player);
                team2.Players[i].FirstName = "Player";
                team2.Players[i].LastName = i.ToString();
                if (i == 0) {
                    team2.Players[i].Position = "mv";
                } else {
                    switch (rand.Next(0, 2)) {
                        case 0:
                            team2.Players[i].Position = "p";
                            break;
                        case 1:
                            team2.Players[i].Position = "h";
                            break;

                    }
                }
                switch (rand.Next(0, 2)) {
                    case 0:
                        team2.Players[i].Handedness = "R";
                        break;
                    case 1:
                        team2.Players[i].Handedness = "L";
                        break;
                }

                Console.Write("    Name: " + team2.Players[i].FirstName + " " + team2.Players[i].LastName + ", ");
                Console.Write("    Position: " + team2.Players[i].Position + ", ");
                Console.WriteLine("    Dominant hand: " + team2.Players[i].Handedness);

                // This text is added only once to the file.
                if (!File.Exists(path1)) {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path1)) { }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path2)) {
                    sw.WriteLine(
                        team2.Players[i].FirstName + ":" + team2.Players[i].LastName + ":"
                        + team2.Players[i].Position + ":" + team2.Players[i].Handedness
                    );
                }
            }

            Console.WriteLine("\nTo the death!");
        }
    }
}
