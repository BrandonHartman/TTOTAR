using System;
using Spectre.Console;

namespace TTOTAR
{
    public class Armor
    {
        public ArmorPlacement Slot { get; set;}
        public required string Name { get; set; }

        public int DefenseBonus { get; set;}
        
        public required string Description { get; set; }

        // TODO: Add properties for durability, weight, special effects, etc.
        public int Weight { get; set; }

        public int Durability { get; set; }

        public int ArmorValue { get; set; }
    }

    public enum ArmorPlacement
    {
        Head,
        Chest,
        Legs,
        Feet,
        Hands
    }

}