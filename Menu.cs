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
        }
    }
}