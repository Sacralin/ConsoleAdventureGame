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
        List<string> actions = new List<string>() {"north", "south", "west", "east", "examine" };
        int menuPosition = 11;
        int movementNotificationPosition = 13;
        int displayLocationPosition = 3; //this also handles dialogue
        bool hasExaminedCrouchRoom = false;
        bool hasExaminedJump = false;
        bool hasSpokenToAdventurerAboutJump = false;
        bool hasSwitchedLever = false;
        bool hasPressedButton = false;

        public MainGame() 
        {
            world = new Map();
            player = new Player();
            Console.CursorVisible = false;
        }

        public void Run()
        {
            Console.WriteLine(DisplayLocation());
            HandleQuests();

            if (player.locationX == 4 && player.locationY == 2)
            {
                Environment.Exit(0);
            }

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
            for(int i = 0; i < actions.Count; i++)
            {
                if(selectedMenuItem == i)
                {
                    Console.Write(">");
                }
                Console.Write($"{actions[i]} ");
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
                if (actions[selectedMenuItem].Equals("north") && currentTile.exitNorth)
                {
                    player.locationY--;
                    Console.WriteLine("You go North");
                }
                else if (actions[selectedMenuItem].Equals("south") && currentTile.exitSouth)
                {
                   player.locationY++;
                   Console.WriteLine("You go South");
                }
                else if (actions[selectedMenuItem].Equals("west") && currentTile.exitWest)
                {
                    player.locationX--;
                    Console.WriteLine("You go West");
                }
                else if (actions[selectedMenuItem].Equals("east") && currentTile.exitEast)
                {
                    player.locationX++;
                    Console.WriteLine("You go East");
                }
                else if (actions[selectedMenuItem].Equals("examine"))
                {
                    Console.WriteLine(currentTile.examineRoom);
                    if (currentTile == world.map[2, 3])
                    {
                        hasExaminedCrouchRoom = true;
                    }
                    if (currentTile == world.map[2, 1])
                    {
                        hasExaminedJump = true;
                    }

                }
                else if (actions[selectedMenuItem].Equals("talk"))
                {
                    HandleNPCConversation();
                }
                else if (actions[selectedMenuItem].Equals("crouch"))
                {
                    world.map[2, 3].exitEast = true;
                }
                else if (actions[selectedMenuItem].Equals("jump"))
                {
                    player.locationY--;
                }
                else if (actions[selectedMenuItem].Equals("lever"))
                {
                    hasSwitchedLever = true;
                    Dialogue("With a firm grasp, you pull the lever downward, feeling the resistance give way with a satisfying click.");
                    Dialogue("A series of mechanical noises echo through the chamber. Gears grind and cogs\n" +
                        "turn as the mechanism comes to life, ancient mechanisms stirring from their long slumber.\n" +
                        "The sound reverberates through the room, filling the air with a symphony of clicks, whirs, and clanks.");
                }
                else if (actions[selectedMenuItem].Equals("button"))
                {
                    hasPressedButton = true;
                    Dialogue("With a curious expression, you press down on the button, feeling a slight resistance before it depresses\n" +
                        "with a soft click.");
                    Dialogue("A series of mystical sounds fills the air, resonating through the chamber like\n" +
                        "a chorus of ancient spirits awakening from their slumber. Ethereal tones dance around you, swirling and mingling\n" +
                        "with the echoes of distant whispers.");
                }
                else
                {
                    Console.WriteLine(noExit);
                }

                
                
            }
        }

        private void HandleQuests()
        {
            if (currentTile == world.map[1, 2])
            {
                if (!actions.Contains("talk")) { actions.Add("talk"); }
            }
            else
            {
                if (actions.Contains("talk")) { actions.Remove("talk"); }
                
            }

            if (currentTile == world.map[2, 3] && hasExaminedCrouchRoom)
            {
                if (!actions.Contains("crouch")) { actions.Add("crouch"); }

            }
            else
            {
                if (actions.Contains("crouch")) { actions.Remove("crouch"); }

            }

            if (currentTile == world.map[2, 1] && hasSpokenToAdventurerAboutJump)
            {
                if (!actions.Contains("jump")) { actions.Add("jump"); }

            }
            else
            {
                if (actions.Contains("jump")) { actions.Remove("jump"); }

            }
            if (currentTile == world.map[1, 0]) //jump lever
            {
                if (!actions.Contains("lever")) { actions.Add("lever"); }

            }
            else
            {
                if (actions.Contains("lever")) { actions.Remove("lever"); }

            }
            if (currentTile == world.map[3, 3] ) //crouch button
            {
                if (!actions.Contains("button")) { actions.Add("button"); }

            }
            else
            {
                if (actions.Contains("button")) { actions.Remove("button"); }

            }

            if(hasSwitchedLever && hasPressedButton)
            {
                world.map[3, 2].exitEast = true;
                world.map[3, 2].roomDescription = 
                    "After activating both the lever and button in previous chambers, the air in the Vault of Secrets hums with anticipation.\n" +
                    "Suddenly, with a low rumble, the stone door begins to creak open, revealing a glimpse of the treasures that lie beyond.";
            }

        }

        private void HandleNPCConversation()
        {
            if (!hasExaminedJump)
            {
                Dialogue("Greetings, adventurer. I've been exploring these ruins for days now, searching for a way out.\n" +
                "But alas, I am unable to continue.");
                Dialogue("It is said that hidden within these walls is a secret passage, accessible only by activating a concealed switch.");
                Dialogue("The switch is well hidden though, be sure to look high and low.");
            }
            

            if(hasExaminedJump)
            {
                Dialogue("Ah, yes, the chasm. A treacherous obstacle, indeed. I'm afraid there's no other path to reach the\n" +
                    "other side, my friend. It's either the jump or turning back.");
                Dialogue("it's a risk, no doubt. But sometimes, in the face of uncertainty, one must trust in their instincts\n" +
                    "and take a leap of faith. I've seen many a brave soul make such jumps and emerge victorious on the other side.\n" +
                    "You have the strength and courage within you, my friend. I believe you can do it.");
                hasSpokenToAdventurerAboutJump = true;
            }
        }

        private void Dialogue(string dialogue)
        {
            Console.SetCursorPosition(0, displayLocationPosition);
            Console.WriteLine(dialogue);
            Console.SetCursorPosition(0, menuPosition);
            Console.WriteLine(">continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
