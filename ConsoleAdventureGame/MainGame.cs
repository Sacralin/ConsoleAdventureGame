using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventureGame
{
    internal class MainGame
    {
        Map world;
        Player player;

        public MainGame() 
        {
            world = new Map();
            player = new Player();
        }

        public void Run()
        {
            
            Console.WriteLine(DisplayLocation());
        }

        private string DisplayLocation()
        {
            MapTile currentTile = world.map[player.locationX, player.locationY];
            return currentTile.roomDescription;
        }

        

    }
}
