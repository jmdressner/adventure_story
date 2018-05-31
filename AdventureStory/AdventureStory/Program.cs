using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player();
            myPlayer.SetName();
            Console.ReadLine();
            myPlayer.SetSuperPower();
            Console.ReadLine();
            myPlayer.SetWeapon();
            Console.ReadLine();

            MysteriousMountains mountains = new MysteriousMountains(myPlayer);
            mountains.MountainRoutes();

            DangerousDepths ocean = new DangerousDepths(myPlayer);
            ocean.DangerousDepthRoutes();

        }
    }
}
