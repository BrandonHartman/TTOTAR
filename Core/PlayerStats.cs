using System;
using Spectre.Console;

namespace TTOTAR
{
    class PlayerStats
    {
        public static void ApplyRaceStats(Player player)
        {
            player.Strength = 10;
            player.Dexterity = 10;
            player.Constitution = 10;
            player.Intelligence = 10;
            player.Wisdom = 10;
            player.Charisma = 10;

            //Apply race modifiers
            switch (player.Race)
            {
                case "Human":
                    // No changes for Human
                    break;
                case "Elf":
                    player.Dexterity += 2;
                    player.Strength -= 1;
                    break;
                case "Dwarf":
                    player.Constitution += 2;
                    player.Dexterity -= 1;
                    break;
                case "Orc":
                    player.Strength += 2;
                    player.Intelligence -= 1;
                    break;
            }
        }

        public static void ApplyClassStats(Player player)
        {
            //Apply class modifiers
            switch (player.Class)
            {
                case "Wizard":
                    player.MaxHealth = 50;
                    player.Health = 50;
                    player.MaxMana = 100;
                    player.Mana = 100;
                    break;
                case "Rogue":
                    player.MaxHealth = 75;
                    player.Health = 75;
                    player.MaxMana = 50;
                    player.Mana = 50;
                    break;
                case "Knight":
                    player.MaxHealth = 100;
                    player.Health = 100;
                    player.MaxMana = 30;
                    player.Mana = 30;
                    break;
            }
        }
    }
}