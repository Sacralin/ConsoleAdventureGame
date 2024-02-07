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
        string noExit = "You cannot go that way!";

        public MainGame() 
        {
            world = new Map();
            player = new Player();
        }

        public void Run()
        {
            Console.WriteLine(DisplayLocation());
            HandleInput();
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
                    Console.WriteLine("You go North");
                }
                else
                {
                    Console.WriteLine(noExit);
                }
            }
            if (input.ToLower().Contains("south") || input.ToLower() == "s")
            {
                if (currentTile.exitSouth)
                {
                    player.locationY++;
                    Console.WriteLine("You go South");
                }
                else
                {
                    Console.WriteLine(noExit);
                }
            }
            if (input.ToLower().Contains("east") || input.ToLower() == "e")
            {
                if (currentTile.exitEast)
                {
                    player.locationX++;
                    Console.WriteLine("You go East");
                }
                else
                {
                    Console.WriteLine(noExit);
                }
            }
            if (input.ToLower().Contains("west") || input.ToLower() == "w")
            {
                if (currentTile.exitWest)
                {
                    player.locationX--;
                    Console.WriteLine("You go West");
                }
                else
                {
                    Console.WriteLine(noExit);
                }
            }

        }

        private void DisplayUI()
        {
            Console.WriteLine();
        }

        

    }
}
