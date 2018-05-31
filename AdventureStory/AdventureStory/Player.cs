using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    class Player
    {
        // member variables
        public string name;
        public string superPower;
        public string weapon;

        // constructor
        public Player()
        {

        }
        // member methods

        public void DisplayName()
        {
            Console.WriteLine("Player: " + name);
        }

        public void SetName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            DisplayName();
        }

        public void SetSuperPower()
        {
            Console.WriteLine("Please select a superpower: the ability to Fly, Breath Underwater, or be Invinsible in Battle.");
            superPower = Console.ReadLine().ToLower();

            switch (superPower)
            {
                case "fly":
                    Console.WriteLine("Awesome! You can fly");
                    break;
                case "breath underwater":
                    Console.WriteLine("Thats amazing! You can breath underwater!");
                    break;
                case "invinsible in battle":
                    Console.WriteLine("Thats crazy! You are invinsible in battle!");
                    break;
                default:
                    Console.WriteLine("That is not a valid superpower, please choose again.");
                    SetSuperPower();
                    break;
            }
        }

        public void SetWeapon()
        {
            Console.WriteLine("Please select a weapon: Sword, Shovel, Ice Pick, Harpoon, Lifevest, or Net.");
            weapon = Console.ReadLine().ToLower();

            switch (weapon)
            {
                case "sword":
                    Console.WriteLine("Awesome! You have a sword!");
                    break;
                case "shovel":
                    Console.WriteLine("Thats amazing! You have a shovel!");
                    break;
                case "ice pick":
                    Console.WriteLine("Great! You have an ice pick.");
                    break;
                case "harpoon":
                    Console.WriteLine("Thats crazy! You have a harpoon!");
                    break;
                case "lifevest":
                    Console.WriteLine("Cool! You have a lifevest.");
                    break;
                case "net":
                    Console.WriteLine("Nice! You have a net.");
                    break;
                default:
                    Console.WriteLine("That is not a valid weapon, please choose again.");
                    SetWeapon();
                    break;
            }
        }

    }
}
