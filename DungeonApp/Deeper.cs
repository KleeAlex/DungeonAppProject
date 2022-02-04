using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DungeonApp
{
    class Deeper
    {
        static void Main(string[] args)
        {
            Console.Title = "A Downward Spiral";
            Console.WriteLine("It's dark, it's cold, but you must push on");

            int score = 0;

            //TODO create player object.
            //TODO create monster object.
            //TODO figure out combat, and weither player wins or loses
            //TODO display for Player & Monster Info/Stats
            //TODO log players life

            bool exit = false;

            do
            {
                Console.WriteLine(GetRoom());

                bool reload = false;

                do
                {
                    #region Menu
                    Console.WriteLine("What will you do?\n" +
                        "P) Push on\n" +
                        "I) Info\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    Console.Clear();

                    switch (userChoice)
                    {       //Movement
                        case ConsoleKey.P:
                            break;
                        case ConsoleKey.I:
                            break;
                        case ConsoleKey.A:
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("There is nowhere to run...");
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
                "You enter a gaudy pink poweder room, and are instantly covered in glitter.",
                "The room is dark and musty with the smell of lost souls.",
                "You arrive in a room filled with chairs and a ticket stub machine... the dreaded DMV.",
                "You enter a quest library... silience... nothing bul silence...",
                "As you enter the room, you realize you are standing on a platform surrounded by sharks.",
                "Oh my... What is that smell? You appear to be standing in a combost pile... ARe those Bones?",
                "You enter a dark room and all you can hear is hair metal mustic blaring.... This is gonna be bad.",
                "The room looks just like the rooom you are sitting in right now... or does it?"
                };

            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;

        }





























    }
}
