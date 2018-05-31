using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    class MysteriousMountains
    {
        // member variables
        public string route;
        public int number;
        public Player player;

        // constructor
        public MysteriousMountains(Player player)
        {
            this.player = player;
        }
        // member methods
        public void MountainRoutes()
        {
            Console.WriteLine("Please select a route up the Mysterious Mountains: Cruel Craigs, Shifting Snow, Slippery Slopes.");
            route = Console.ReadLine().ToLower();

            switch (route)
            {
                case "cruel craigs":
                    Console.WriteLine("Good luck, and keep a sharp eye out for the abominable snow man.");
                    Console.ReadLine();
                    CruelCraigs();
                    break;
                case "shifting snow":
                    Console.WriteLine("Break a leg, and beware of avalanches.");
                    Console.ReadLine();
                    ShiftingSnow();
                    break;
                case "slippery slopes":
                    Console.WriteLine("Godspeed, and watch your footing through the icefields.");
                    SlipperySlopes();
                    break;
                default:
                    Console.WriteLine("That is not a valid route, please choose again.");
                    Console.ReadLine();
                    MountainRoutes();
                    break;
            }
        }

        public void CruelCraigs()
        {
            Console.WriteLine("Oh no! While you were climbing you found the abominable snowman and he isn't to happy to see you. Prepare to fight!");
            Console.ReadLine();
            if (player.weapon == "sword" || player.superPower == "invinsible in battle")
            {
                Console.WriteLine("Awesome job! With your sword or superpower the abominable snowman was no match for you!");
                Console.ReadLine();
                IceCastle();
            }
            else
            {
                RandomNumber(0,20);
                if (number > 5)
                {
                    Console.WriteLine("Great job! Through your wit and you escaped the abominable snowman");
                    Console.ReadLine();
                    IceCastle();
                }
                else
                {
                    Console.WriteLine("OH NO! The abominable snowman was to fast for you.  Please start over." );
                    Console.ReadLine();
                }
            }
        }

        public void ShiftingSnow()
        {
            Console.WriteLine("Oh no! Suddenly while you are hiking through the snow there is a rumble. AVALANCHE!");
            Console.ReadLine();
            if (player.weapon == "shovel")
            {
                Console.WriteLine("Phew, eventhough you got buried you were able to dig yourself out with your shovel.");
                Console.ReadLine();
                IceCastle();
            }
            else
            {
                RandomNumber(0, 20);
                if (number > 5)
                {
                    Console.WriteLine("Nice reflexes! You were able to throw yourself behind a large rock so you weren't buried.");
                    Console.ReadLine();
                    IceCastle();
                }
                else
                {
                    Console.WriteLine("OH NO! The avalanche was to much for you and you got buried. Please start over.");
                    Console.ReadLine();
                }
            }
        }

        public void SlipperySlopes()
        {
            Console.WriteLine("Oh no! The only way forwawrd is through treacherous ice fields!");
            Console.ReadLine();
            if (player.weapon == "ice pick" || player.superPower == "fly")
            {
                Console.WriteLine("Nicely done! With your ice pick or superpower you were able to get through the treacherous ice fields without a scratch.");
                Console.ReadLine();
                IceCastle();
            }
            else
            {
                RandomNumber(0, 20);
                if (number > 5)
                {
                    Console.WriteLine("Good job! With your persistance and courage you were able to get through with only falling down a few times.");
                    Console.ReadLine();
                    IceCastle();
                }
                else
                {
                    Console.WriteLine("Sad day! You slipped on some ice and fell into an ice crevice.  Please start over.");
                    Console.ReadLine();
                }
            }
        }

        public void IceCastle()
        {
            Console.WriteLine("Great job! You made it to the legendary Ice Castle at the top of the Mysterious Mountain peaks.\n" +
                "Inside you find the mythical mirror of Lore that will show you where an ancient treasure of kings is hidden.\n" +
                "While gazing in the mythical mirror of Lore, you see the outline of a treacherous shore.\n" +
                "Then the view takes a dive under the water, through the murky depths you see the skeleton of a sunken ship take shape.\n" +
                "The treasure that you seek is sunken below the livable world in the dangerous depths of the ocean.\n" +
                "If you dare, continue on to the Dangerous Depths where a priceless treasure lies buried and unknown dangers await.");
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
