﻿using System.Xml.Serialization;

namespace ConsoleAdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainGame game = new MainGame();

            while (true)
            {
                game.Run();
                
            }
           
        }


    }
}