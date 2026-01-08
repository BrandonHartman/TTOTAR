using System;
using Spectre.Console;

namespace TTOTAR
{
    class ConsoleMenu
    {
        public static void ShowMainMenu()
        {
            var menuOptions = new[]
            {
                "Start New Game",
                "Load Game",
                "Settings",
                "Exit"
            };
            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .PageSize(10)
                    .AddChoices(menuOptions));
            switch (selection)
            {
                case "Start New Game":
                    var player = CharacterCreation.CreateCharacter();
                    if (player != null)
                    {
                        // Character was created successfully!
                        AnsiConsole.MarkupLine($"[green]Character {player.Name} created![/]");
                        AnsiConsole.MarkupLine($"Race: {player.Race}, Class: {player.Class}");
                        AnsiConsole.MarkupLine($"Stats - STR:{player.Strength} DEX:{player.Dexterity} CON:{player.Constitution} INT:{player.Intelligence}");
                        AnsiConsole.MarkupLine($"HP: {player.Health}/{player.MaxHealth} | Mana: {player.Mana}/{player.MaxMana}");
                        Console.ReadKey();
                        // TODO: Start the actual game here
                        ShowMainMenu(); // For now, go back to menu
                    }
                    break;
                case "Load Game":
                    AnsiConsole.MarkupLine("[green]Loading game...[/]");
                    //LoadGame();
                    break;
                case "Settings":
                    Settings.OpenSettings();
                    break;
                case "Exit":
                    AnsiConsole.MarkupLine("[green]Exiting the game. Goodbye![/]");
                    Environment.Exit(0);
                    break;
                default:
                    AnsiConsole.MarkupLine("[red]Invalid selection. Please try again.[/]");
                    break;
            }
        }
    }
}