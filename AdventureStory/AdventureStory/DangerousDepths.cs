using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    class DangerousDepths
    {
        // member variables
        public string route;
        public int number;
        public Player player;

        // constructor
        public DangerousDepths(Player player)
        {
            this.player = player;
        }
        // member methods
        public void DangerousDepthRoutes()
        {
            Console.WriteLine("Please select a route into the Dangerous Depths: Menacing Shallows, Sinister Shores, Perilous Waves.");
            route = Console.ReadLine().ToLower();

            switch (route)
            {
                case "menacing shallows":
                    Console.WriteLine("Bon Voyage! And beware of hungry sharks.");
                    Console.ReadLine();
                    MenacingShallows();
                    break;
                case "sinister shores":
                    Console.WriteLine("Best of Luck! I hope you're a strong swimmer because I've heard there can a nasty riptide.");
                    Console.ReadLine();
                    SinisterShores();
                    break;
                case "perilous waves":
                    Console.WriteLine("Good Luck! Keep an eye out for swarms of jellyfish.");
                    PerilousWaves();
                    break;
                default:
                    Console.WriteLine("That is not a valid route, please choose again.");
                    Console.ReadLine();
                    DangerousDepthRoutes();
                    break;
            }
        }

        public void MenacingShallows()
        {
            Console.WriteLine("Oh no! While you were swimming out to the sunken ship you spot a menacing fin. SHARK!");
            Console.ReadLine();
            if (player.weapon == "harpoon" || player.superPower == "invinsible in battle")
            {
                Console.WriteLine("Nicely done! With your harpoon or superpower you were able to take down that hungry shark.");
                Console.ReadLine();
                TreasureOfKings();
            }
            else
            {
                RandomNumber(0, 20);
                if (number > 5)
                {
                    Console.WriteLine("Great job! You were able to hide in a sea cave until the shark went away.");
                    Console.ReadLine();
                    TreasureOfKings();
                }
                else
                {
                    Console.WriteLine("Sad day! The shark was to fast for you.  Please start over.");
                    Console.ReadLine();
                }
            }
        }

        public void SinisterShores()
        {
            Console.WriteLine("Oh no! While you were swimming out to the sunken ship the ripetide got to strong and pulls you under!");
            Console.ReadLine();
            if (player.weapon == "lifevest" || player.superPower == "breath underwater")
            {
                Console.WriteLine("Nicely done! With your lifevest or superpower you were able to escape the ripetide .");
                Console.ReadLine();
                TreasureOfKings();
            }
            else
            {
                RandomNumber(0, 20);
                if (number > 5)
                {
                    Console.WriteLine("Great job! You are a strong swimmer eventhough you swallowed some water you managed to make it out.");
                    Console.ReadLine();
                    TreasureOfKings();
                }
                else
                {
                    Console.WriteLine("Sad day! The ripetide was to strong for you.  Please start over.");
                    Console.ReadLine();
                }
            }
        }

        public void PerilousWaves()
        {
            Console.WriteLine("Oh no! While you were swimming out to the sunken ship you see an ominous swarm of jellyfish.");
            Console.ReadLine();
            if (player.weapon == "net")
            {
                Console.WriteLine("Nicely done! With your net you were able to trap the jellyfish and get away.");
                Console.ReadLine();
                TreasureOfKings();
            }
            else
            {
                RandomNumber(0, 20);
                if (number > 5)
                {
                    Console.WriteLine("Great job! You were able to swim around them before they got to you.");
                    Console.ReadLine();
                    TreasureOfKings();
                }
                else
                {
                    Console.WriteLine("Sad day! The jellyfish were to much for you.  Please start over.");
                    Console.ReadLine();
                }
            }
        }

        public void TreasureOfKings()
        {
            Console.WriteLine("Treasure");
            Console.ReadLine();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            number = random.Next(0, 20);
            return number;
        }
    }
}
