using System;
using Spectre.Console;

namespace TTOTAR
{
    public static class Settings
    {
        public static int TextSpeed { get; set; } = 30; // Default text speed
       
        // TODO: public static string Difficulty { get; set; } = "Normal"; // Default difficulty

        public static void OpenSettings()
        {
            var speedOptions = new[]
            {
                "Slow (50ms per character)",
                "Normal (30ms per character)",
                "Fast (10ms per character)",
                "Instant (0ms)",
                "Back to Main Menu"
            };

            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[blue]Settings - Text Speed[/]")
                    .AddChoices(speedOptions));

            switch (selection)
            {
                case "Slow (50ms per character)":
                    TextSpeed = 50;
                    AnsiConsole.MarkupLine("[green]Text speed set to Slow[/]");
                    break;
                case "Normal (30ms per character)":
                    TextSpeed = 30;
                    AnsiConsole.MarkupLine("[green]Text speed set to Normal[/]");
                    break;
                case "Fast (10ms per character)":
                    TextSpeed = 10;
                    AnsiConsole.MarkupLine("[green]Text speed set to Fast[/]");
                    break;
                case "Instant (0ms)":
                    TextSpeed = 0;
                    AnsiConsole.MarkupLine("[green]Text speed set to Instant[/]");
                    break;
                case "Back to Main Menu":
                    break;
            }

            Thread.Sleep(1000); // Pause so user can see the message
            ConsoleMenu.ShowMainMenu();
        }
        // Helper method to write text with a typewriter effect
        public static void WriteWithSpeed(string text)
        {
            if (TextSpeed == 0)
            {
                Console.Write(text);
            }
            else
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(TextSpeed);
                }
            }
        }
        // Supports Spectre markup colors!
        public static void WriteWithSpeedMarkup(string markupText)
        {
            if (TextSpeed == 0)
            {
                AnsiConsole.Markup(markupText);
            }
            else
            {
                // Parse the markup and write character by character
                foreach (char c in markupText)
                {
                    Console.Write(c);
                    Thread.Sleep(TextSpeed);
                }
            }
        }
    }
}