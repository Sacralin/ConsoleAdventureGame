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
        int selectedMenuItem;
        List<string> actions = new List<string>() {"north", "south", "east", "west"};
        int menuPosition = 11;
        int movementNotificationPosition = 13;
        int displayLocationPosition = 4;

        public MainGame() 
        {
            world = new Map();
            player = new Player();
            Console.CursorVisible = false;
        }

        public void Run()
        {
            Console.WriteLine(DisplayLocation());
            HandleInput();
            
        }

        private string DisplayLocation()
        {
            Console.SetCursorPosition(0, displayLocationPosition);
            currentTile = world.map[player.locationX, player.locationY];
            string exits = "You can go ";
            if (currentTile.exitNorth) { exits += "north "; }
            if (currentTile.exitSouth) { exits += "south "; }
            if (currentTile.exitWest) { exits += "west "; }
            if (currentTile.exitEast) { exits += "east "; }
            return $"{currentTile.roomName}\n{currentTile.roomDescription}\n\n{exits}";
        }

        private void HandleInput()
        {
            Console.SetCursorPosition(0, menuPosition);
            switch (selectedMenuItem)
            {
                case 0:
                    Console.WriteLine(">North  South  West  East");
                    break;
                case 1:
                    Console.WriteLine(" North >South  West  East");
                    break;
                case 2:
                    Console.WriteLine(" North  South >West  East");
                    break;
                case 3:
                    Console.WriteLine(" North  South  West >East");
                    break;
                default:
                    Console.WriteLine("ERROR: Selected Menu Item Not Found.");
                    break;
            }

            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            if (key.KeyChar.ToString().Equals("d"))
            {
                selectedMenuItem++;
                if (selectedMenuItem >= actions.Count)
                {
                    selectedMenuItem = 0;
                }
            }
            
            if (key.KeyChar.ToString().Equals("a"))
            {
                selectedMenuItem--;
                if (selectedMenuItem == -1 )
                {
                    selectedMenuItem = actions.Count -1;
                }
            }
            
            if (key.KeyChar.ToString().Equals(" "))
            {
                Console.SetCursorPosition(0, movementNotificationPosition);
                if (selectedMenuItem == 0 && currentTile.exitNorth)
                {
                    player.locationY--;
                    Console.WriteLine("You go North");
                }
                else if (selectedMenuItem == 1 && currentTile.exitSouth)
                {
                   player.locationY++;
                   Console.WriteLine("You go South");
                }
                else if (selectedMenuItem == 2 && currentTile.exitWest)
                {
                    player.locationX--;
                    Console.WriteLine("You go West");
                }
                else if (selectedMenuItem == 3 && currentTile.exitEast)
                {
                    player.locationX++;
                    Console.WriteLine("You go East");
                }
                else
                {
                    Console.WriteLine(noExit);
                }
                
            }
        }

    }
}
