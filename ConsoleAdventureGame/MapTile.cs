using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventureGame
{
    internal class MapTile
    {
        public string roomName = "default";
        public string roomDescription = "default";
        public bool exitNorth;
        public bool exitSouth;
        public bool exitEast;
        public bool exitWest;

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
