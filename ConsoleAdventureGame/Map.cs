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
                "seems to follow you.\n" +
                "You see a Weary Adventurer here with you");
            map[2, 2] = new MapTile("Chamber of Serenity", true, true, true, true, 
                "A tranquil chamber bathed in soft, golden light. Fragrant incense fills the air, and a gentle breeze rustles\n" +
                "through the colorful curtains that hang from the windows. It's a peaceful respite from the dangers lurking\n" +
                "in the temple's depths.");
            //go north to jump puzzle
            map[2, 1] = new MapTile("Precarious Chasm", false, true, false, false, 
                "Before you stretches a gaping chasm, its depths shrouded in darkness. On the other side,\n" +
                "a distant platform beckons, adorned with ancient runes and mysterious symbols.\n" +
                "The distance between you and the platform seems daunting, and the gap appears to be too wide to jump safely.",
                "Should you attempt the jump, risking life and limb for the promise of what lies beyond?\n" +
                "Or is there another, safer path you could take? Maybe the Weary Adventurer knows of a safer path.");
            map[2, 0] = new MapTile("Triumph's Landing", false, false, true, false,
                "Within this vast chamber, adorned with ancient murals, you land safely on the distant platform.\n" +
                "Relief floods through you as you realize your leap of faith was successful. You quickly realise \n" +
                "you cannot make the jump back, igniting triumphant determination to face what lies ahead.");
            map[1, 0] = new MapTile("Dimly lit chamber", false, true, false, true, 
                "In this dimly lit chamber, you discover an ancient mechanism hidden within the walls.\n" +
                "As you approach, you notice a lever protruding from the stone, covered in dust and cobwebs.");
            map[1, 1] = new MapTile("Whispering Chamber", true, true, false, false,
                "As you step into this chamber, your eyes are drawn to the subtle flicker of torchlight illuminating\n" +
                "a hidden door on the southern wall. The room is dimly lit, with shadows dancing along the rough stone floor.");
            //go east to door puzzle
            map[3, 2] = new MapTile("Vault of Secrets", false, false, true, false, 
                "Within the heart of the temple lies the Vault of Secrets, a chamber shrouded in mystery and guarded by\n" +
                "ancient mechanisms. At the far end of the room stands a massive stone door, adorned with intricate\n" +
                "carvings and sealed shut for centuries.");
            map[4, 2] = new MapTile("Dans Ending", false, false, false, false, "An ending as requested by Dan, plus a load of treasure for him\n *smiley face*");
            //go south to crouch puzzle
            map[2, 3] = new MapTile("Hidden Passage", true, false, false, false,
                "This room appears to be a dead end, with solid walls stretching to the ceiling.",
                "Upon closer inspection, you notice a narrow gap near the floor, partially obscured by overgrown vines and rubble.\n" +
                "The space is just tall enough for a person to crouch and squeeze through.");
            map[3, 3] = new MapTile("Hall of Enigmas", false, false, true, false, 
                "Within this enigmatic hall, adorned with intricate glyphs and mysterious symbols, you uncover a peculiar pedestal.\n" +
                "At its center rests a small, unassuming button, its surface worn with age");
            
            
            
            
            


        }




    }
}
