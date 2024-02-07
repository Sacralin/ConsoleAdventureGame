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
            //main corridor
            map[0, 2] = new MapTile("Entrance Hall", false, false, false, true,                                                      //Character limit kinda
                "You are in a grand hall with towering pillars and faded tapestries adorning the walls.\n" +
                "Sunlight filters in through cracks in the ceiling, casting eerie shadows on the ancient stone floor.");
            map[1, 2] = new MapTile("Corridor of Echoes", false, false, true, true,
                "You are in a long corridor lined with intricate carvings depicting scenes of ancient battles and mythical\n" +
                "creatures. Every step you take reverberates through the narrow passageway, creating an eerie echo that\n" +
                "seems to follow you.");
            map[2, 2] = new MapTile("Chamber of Serenity", true, true, true, true, 
                "A tranquil chamber bathed in soft, golden light. Fragrant incense fills the air, and a gentle breeze rustles\n" +
                "through the colorful curtains that hang from the windows. It's a peaceful respite from the dangers lurking\n" +
                "in the temple's depths.");
            //go north to jump puzzle
            map[2, 1] = new MapTile("jump room", true, true, false, false, "jump from this room to jump room 2");
            map[2, 0] = new MapTile("jump room2", false, false, true, false, "cant go back to jump room 1 from here so go round");
            map[1, 0] = new MapTile("backroom1 jump puzzle", false, true, false, true, "place a lever or something in this room to interact with");
            map[1, 1] = new MapTile("backroom2 jump puzzle", false, true, false, true, "go south from here to go back to the old man (one way trip)");
            //go east to door puzzle
            map[3, 2] = new MapTile("Exit Room", false, false, true, false, "opens when both levers are pulled"); // set the east to true when the door is open
            //go south to crouch puzzle
            map[2, 3] = new MapTile("crouch room", true, false, false, true, "you can crouch to go east from here");
            map[3, 3] = new MapTile("crouch room interactable", false, false, true, false, "place an interactable item in this room");
            
            
            
            
            


        }




    }
}
