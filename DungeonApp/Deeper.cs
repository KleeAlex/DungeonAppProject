using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using MonsterLibrary;


namespace DungeonApp
{
    class Deeper
    {
        static void Main(string[] args)
        {
            Console.Title = "A Downward Spiral";
            Console.WriteLine("It's dark, it's cold, but you must push on");

            int score = 0;

            Weapon spear = new Weapon(1, 9, "Short Spear", 10);

            Player player = new Player("E-----l", 60, 5, 40, 40, spear);

            
            //TODO figure out combat, and weither player wins or loses
            //TODO display for Player & Monster Info/Stats
            //TODO log players life

            bool exit = false;

            do
            {
                Console.WriteLine(GetRoom());

                Skeleton s1 = new Skeleton();

                Ghoul g1 = new Ghoul();

                BoneDrake bd1 = new BoneDrake();

                BoneDrake bd2 = new BoneDrake("Steel Bone Drake", 30, 30, 60, 20, 3, 10, "Like the other Bone Drakes, but it's bones are infused with metal.", true);

                Shadow sd1 = new Shadow();

                Shadow sd2 = new Shadow("???", 25, 25, 75, 30, 2, 9, "Every cell of your body says to run.", true);

                Monster[] monsters = { s1, s1, s1, s1, s1, g1, g1, g1, g1, g1, bd1, bd1, bd2, sd1, sd2 };

                Random rand = new Random();

                int randomNbr = rand.Next(monsters.Length);

                Monster monster = monsters[randomNbr];

                Console.WriteLine("\nIn this room you encounter a " + monster.Name);

                    
                bool reload = false;

                do
                {
                    #region Menu
                    Console.WriteLine("What will you do?\n" +
                        "P) Player Info\n" +
                        "I) Info\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    Console.Clear();

                    switch (userChoice)
                    {       //Movement
                        case ConsoleKey.P:
                            Console.WriteLine("Player Info");

                            Console.WriteLine(player);

                            Console.WriteLine("Monsters Defeated" + score);
                            break;
                        case ConsoleKey.I:
                            Console.WriteLine("Monster Info");

                            Console.WriteLine(monster);
                            break;
                        case ConsoleKey.A:
                            Combat.DoBattle(player, monster);

                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}!\n", monster.Name);
                                reload = true;
                              
                                score++;
                            }
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("There is nowhere to run...");
                            reload = true;
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("...What are you on about?");
                            break;
                    }
                    #endregion

                } while (!reload && !exit);

            } while (!exit);

            Console.WriteLine("You manged enough, I'd give you..." + score + " points, rest now." + ((score == 1) ? "." : "s."));

        }


        private static string GetRoom() //TODO change rooms, this is a placeholder
        {
            string[] rooms =
            {
                "You enter plain stone room",
                "The room is dark and musty with the smell of lost souls.",
                "You arrive in a room filled with chairs all aranged in a half circle above you, like someone is watching you.",
                "You enter a quest library... silience... nothing bul silence...",
                "As you enter the room, you hear a loud screech from behind you.",
                "Oh... What is that sound? It sounds like... Crunching?",
                "When you enter a chill runs up your spine, you hear a weak whisper from behind you '...r..un...'",
                "The room seems to extend endlessly, the further you push the longer the it seems to get."
                };

            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;

        }





























    }
}
