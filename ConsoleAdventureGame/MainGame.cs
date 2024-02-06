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
        MapTile currentTile;

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
            currentTile = world.map[player.locationX, player.locationY];
            return currentTile.roomDescription;
        }

        private void HandleInput()
        {
            string input;
            input = Console.ReadLine();
            if (input.ToLower().Contains("north") || input.ToLower() == "n")
            {
                if(currentTile.exitNorth)
                {
                    player.locationY--;
                }
            }
            if (input.ToLower().Contains("south") || input.ToLower() == "s")
            {
                if (currentTile.exitSouth)
                {
                    player.locationY++;
                }
            }
            if (input.ToLower().Contains("east") || input.ToLower() == "e")
            {
                if (currentTile.exitEast)
                {
                    player.locationX--;
                }
            }
            if (input.ToLower().Contains("west") || input.ToLower() == "w")
            {
                if (currentTile.exitWest)
                {
                    player.locationX++;
                }
            }

        }

        

    }
}
