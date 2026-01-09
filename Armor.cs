using System;
using Spectre.Console;

namespace TTOTAR
{
    public class Armor
    {
        public ArmorPlacement Slot { get; set;}

        public ArmorRarity ArmorRarity { get; set; }

        public ArmorType ArmorType { get; set; }

        public ArmorCategory ArmorCategory { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }

        public int DefenseBonus { get; set;}

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
    public enum ArmorRarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }
    public enum ArmorType
    {
        Light,
        Medium,
        Heavy
    }
    public enum ArmorCategory
    {
        Cloth,
        Leather,
        Chainmail,
        Plate
    }

}