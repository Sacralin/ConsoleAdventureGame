using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventureGame
{
    internal class MapTile
    {
        string roomName = "default";
        string roomDescription = "default";
        bool exitNorth;
        bool exitSouth;
        bool exitEast;
        bool exitWest;

        public MapTile(string name, bool north, bool south, bool east, bool west, string desc)
        {
            name = roomName;
            desc = roomDescription;
            north = exitNorth;
            south = exitSouth;
            east = exitEast;
            west = exitWest;
        }

    }
}
