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
                    // .Title("Select an option:")
                    .PageSize(10)
                    .AddChoices(menuOptions));
            switch (selection)
            {
                case "Start New Game":
                    AnsiConsole.MarkupLine("[green]Starting a new game...[/]");
                    //StartNewGame();
                    break;
                case "Load Game":
                    AnsiConsole.MarkupLine("[green]Loading game...[/]");
                    //LoadGame();
                    break;
                case "Settings":
                    AnsiConsole.MarkupLine("[green]Opening settings...[/]");
                    //OpenSettings();
                    break;
                case "Exit":
                    AnsiConsole.MarkupLine("[green]Exiting the game. Goodbye![/]");
                    Environment.Exit(0); // Exit the application
                    break;
                default:
                    AnsiConsole.MarkupLine("[red]Invalid selection. Please try again.[/]");
                    break;
            }
        }
    }
}