using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l02_a09 {
    class Program {
        static void Main(string[] args) {
            char[] word = new char[12] { 'm', 'i', 'e', 's', 'k', 'o', 'l', 'a', 'i', 'n', 'e', 'n' };
            char guess;
            int length = word.Length;
            char[] reveal = new char[word.Length];
            int success = 0;
            int success2 = 0;
            int failure = 0;

            for (int i = length - 1; i >= 0; i--) {
                reveal[i] = '_';
            }

            while (true) {
                success = 0;
                Console.WriteLine(reveal);
                Console.Write("\n");

                for (int i = length - 1; i >= 0; i--) {
                    if (reveal[i] == word[i]) {
                        success++;
                    }
                }
                if (success == length) {
                    Console.WriteLine("You scream the last letter of the king's name with what little breath you have remaining.");
                    Console.WriteLine("The crowd goes silent, and for a moment you can see king Mieskolainen's eyes go wide.");
                    Console.WriteLine("But it doesn't last long. Soon it turns to a wicked smile, like he was excitedly");
                    Console.WriteLine("waiting for this exact moment. You feel your stomach sink, as he opens his mouth");
                    Console.WriteLine("and says with a voice as if from the depths of hell:");
                    Console.WriteLine("\"May the moose hunts begin.\"\n");
                    break;
                }

                switch (failure) {
                    case 0:
                        Console.WriteLine("You're standing safely on the platform, although with a noose around your neck.");
                        Console.WriteLine("Save for a few jeers, the crowd remains relatively silent.");
                        Console.WriteLine("The king himself is spectating your soon-to-be execution. He looks on expressionlessly.\n");
                        break;
                    case 1:
                        Console.WriteLine("The reality of the situation dawns on you when the noose tightens around your neck,");
                        Console.WriteLine("raising you a little. The crowd starts getting excited with the name-calling growing.");
                        Console.WriteLine("The king is unable to be completely unaffected by the crowd and is now focusing on you.\n");
                        break;
                    case 2:
                        Console.WriteLine("Cold sweat starts forming on your face while breathing becomes harder.");
                        Console.WriteLine("The crowd enjoys your objective suffering. You ponder how many of these");
                        Console.WriteLine("know what you did, or if they even care, even if you were wrongly accused...\n");
                        break;
                    case 3:
                        Console.WriteLine("Only the tips of your toes can touch the platform now. It is incredibly painful to");
                        Console.WriteLine("talk. You know after this next attempt you will be completely at the mercy of");
                        Console.WriteLine("gravity. Memories of your past life start going through your mind.\n");
                        break;
                    case 4:
                        Console.WriteLine("Finally you're lifted in the air. You can not breathe, but it does not stop");
                        Console.WriteLine("you from trying. The crowd laughs at your ugly visage and your wet pants,");
                        Console.WriteLine("although in your horror and panic you can not notice.");
                        Console.WriteLine("Soon your salvation comes, and all turns black...\n");
                        Console.WriteLine("GAME OVER\n");
                        break;
                }
                if (failure == 4) {
                    break;
                }
                Console.WriteLine("Guess a character: ");
                string line = Console.ReadLine();
                if (char.TryParse(line, out guess)) {
                    for (int i = length - 1; i >= 0; i--) {
                        if (guess == word[i]) {
                            reveal[i] = word[i];
                            success2++;
                        }
                    }
                    if (success2 == 0) {
                        failure++;
                    }
                    success2 = 0;
                }
                Console.Clear();
            } // while
        }
    }
}
