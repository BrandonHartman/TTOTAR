using System;
using Spectre.Console;

namespace TTOTAR
{
    class Player
    {
        // Basic player information
        public required string Name { get; set; }
        public required string Race { get; set; }
        public required string Class { get; set; }

        // Player Stats
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        // Other values to store later
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public int Gold { get; set; }
    }
}