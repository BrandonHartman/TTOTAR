using System;
using Spectre.Console;
using System.Threading;

namespace TTOTAR
{
    class Game
    {
        private Player player;

        public Game(Player player)
        {
            this.player = player;
        }

        public void Start()
        {
            AnsiConsole.Clear();
            Settings.WriteWithSpeed($"Welcome to your adventure, {player.Name}!\n");
            Settings.WriteWithSpeed("Your journey through the Ashen Realm begins...\n\n");
            Thread.Sleep(1500);

            // Main game loop - keeps running until player exits
            bool isPlaying = true;
            while (isPlaying)
            {
                isPlaying = ShowGameMenu();
            }

            // When they exit, go back to main menu
            ConsoleMenu.ShowMainMenu();
        }

        private bool ShowGameMenu()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new Rule($"[green]{player.Name} - Level 1[/]").RuleStyle("green"));
            AnsiConsole.MarkupLine($"[dim]HP: {player.Health}/{player.MaxHealth} | Mana: {player.Mana}/{player.MaxMana}[/]");
            AnsiConsole.WriteLine();

            var options = new[] 
            { 
                "Explore",
                "Inventory",
                "Rest",
                "View Stats", 
                "Exit to Main Menu" 
            };

            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What would you like to do?")
                    .AddChoices(options));

            switch (choice)
            {
                case "Explore":
                    Explore();
                    return true; // Keep playing
                case "Inventory":
                    ViewInventory();
                    return true;
                case "View Stats":
                    ViewStats();
                    return true;
                case "Rest":
                    Rest();
                    return true;
                case "Exit to Main Menu":
                    return false; // Stop playing
                default:
                    return true;
            }
        }

        private void Explore()
        {
            AnsiConsole.Clear();
            Settings.WriteWithSpeed("You venture forth into the unknown...\n");
            Thread.Sleep(1000);
            Settings.WriteWithSpeed("You find a peaceful clearing. Nothing interesting here.\n");
            Thread.Sleep(1000);
            AnsiConsole.MarkupLine("\n[dim]Press any key to continue...[/]");
            Console.ReadKey();
            // TODO: Add random encounters, loot, etc.
        }

        private void ViewInventory()
        {
            AnsiConsole.Clear();
            Settings.WriteWithSpeed("You open your inventory...\n");
            Thread.Sleep(1000);
            if (player.Inventory.Count == 0)
            {
                Settings.WriteWithSpeedMarkup("[red]Your inventory is empty.[/]\n");
                Thread.Sleep(1000);
            }
            else
            {
                Settings.WriteWithSpeed("You have the following items:\n");
                foreach (var item in player.Inventory)
                {
                    AnsiConsole.MarkupLine($"- {item.ToString()}\n");
                }
            }
            AnsiConsole.MarkupLine("\n[dim]Press any key to continue...[/]");
            Console.ReadKey();
        }

        private void ViewStats()
        {
            AnsiConsole.Clear();
            var table = new Table();
            table.Border(TableBorder.Rounded);
            table.Title($"[yellow]{player.Name}'s Character Sheet[/]");
            table.AddColumn("Attribute");
            table.AddColumn("Value");

            table.AddRow("[bold]Name[/]", player.Name);
            table.AddRow("[bold]Race[/]", player.Race);
            table.AddRow("[bold]Class[/]", player.Class);
            table.AddRow("", ""); // Blank row
            table.AddRow("[green]Health[/]", $"{player.Health}/{player.MaxHealth}");
            table.AddRow("[blue]Mana[/]", $"{player.Mana}/{player.MaxMana}");
            table.AddRow("", ""); // Blank row
            table.AddRow("Strength", player.Strength.ToString());
            table.AddRow("Dexterity", player.Dexterity.ToString());
            table.AddRow("Constitution", player.Constitution.ToString());
            table.AddRow("Intelligence", player.Intelligence.ToString());

            AnsiConsole.Write(table);
            AnsiConsole.MarkupLine("\n[dim]Press any key to continue...[/]");
            Console.ReadKey();
        }

        private void Rest()
        {
            AnsiConsole.Clear();
            Settings.WriteWithSpeed("You find a safe spot and rest...\n");
            Thread.Sleep(1500);

            // Restore health and mana
            int healthRestored = player.MaxHealth - player.Health;
            int manaRestored = player.MaxMana - player.Mana;

            player.Health = player.MaxHealth;
            player.Mana = player.MaxMana;

            Settings.WriteWithSpeed($"Health restored: +{healthRestored}\n");
            Settings.WriteWithSpeed($"Mana restored: +{manaRestored}\n");
            Settings.WriteWithSpeed("You feel refreshed!\n");

            Thread.Sleep(2000);
            AnsiConsole.MarkupLine("\n[dim]Press any key to continue...[/]");
            Console.ReadKey();
        }
    }
}