using System.Xml.Serialization;

namespace ConsoleAdventureGame
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            string playerName;

            Console.WriteLine("Welcome to the Lost Temple!\n");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Enter Name");
            playerName = Console.ReadLine();
            if(playerName == "")
            {
                playerName = "Player";
            }

            Console.WriteLine("You find yourself standing at the entrance of an ancient temple, its stone facade weathered by centuries of neglect");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("The legends speak of great treasures hidden within its depths, guarded by cunning traps and puzzles.");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("With a sense of determination, you step forward into the unknown.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Weary Traveler: Ah, greetings, adventurer. I've been exploring these ruins for days now, searching for a way out. But alas, I fear I am lost.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"{playerName}: Lost, you say? Is there anything you've discovered that might help me navigate these halls? ");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Weary Traveler: Indeed, there is. Hidden within these walls is a secret passage, accessible only by activating a concealed switch. Look for the symbol of the serpent, and you shall find your way.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"{playerName}: The symbol of the serpent... Got it. Thank you for the information.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Weary Traveler: May fortune favor your journey, brave soul. And beware, for the depths of this temple hold many dangers.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("With the traveler's words echoing in your mind, you set forth, determined to uncover the secrets of the temple and find the elusive switch he spoke of.");
            Console.ReadKey();
            Console.Clear();

            

            while (true)
            {

            }

        }

        

        

    }
}