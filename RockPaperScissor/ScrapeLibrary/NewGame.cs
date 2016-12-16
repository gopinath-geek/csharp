using System;

namespace ScrapeLibrary
{
    public static class NewGame
    {
        public static int Start()
        {
            Random rand = new Random();
            int dice = rand.Next(1, 4);
            return dice;
        }
    }
}
