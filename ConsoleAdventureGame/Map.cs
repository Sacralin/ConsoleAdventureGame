using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventureGame
{
    internal class Map
    {
        public MapTile[,] map;
        

        public Map()
        {
            map = new MapTile[5, 5];
            AddRooms();
        }

        public void AddRooms()
        {
            map[0, 2] = new MapTile("Entrance Hall", false, false, false, true,
                "You are in a grand hall with towering pillars and faded tapestries adorning the walls. " +
                "Sunlight filters in through cracks in the ceiling, casting eerie shadows on the ancient stone floor.");
            map[1, 2] = new MapTile("Corridor of Echoes", false, false, true, true,
                "You are in a long corridor lined with intricate carvings depicting scenes of ancient battles and mythical creatures." +
                " Every step you take reverberates through the narrow passageway, creating an eerie echo that seems to follow you.");

        }




    }
}
