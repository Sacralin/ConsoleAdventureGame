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

        public MapTile(string name, bool north, bool south, bool west, bool east, string desc)
        {
            roomName = name;
            roomDescription = desc;
            exitNorth = north;
            exitSouth = south;
            exitEast = east;
            exitWest = west;
        }

    }
}
