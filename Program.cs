using System;
using Spectre.Console;

/*
    TODO: Look into a TUI library
    TODO: Create a Menu system that shows title, start new game, load game, settings, exit
    

    
*/

namespace TTOTAR
{
    class Program
    {
        static void Main(string[] args)
        {

            var fileName = "Authentication.cs";
            var dependency = "Newtonsoft.Json";

            AnsiConsole.MarkupLine("[green]✓ Build completed successfully[/]");
            AnsiConsole.MarkupLineInterpolated($"[#FFA500]⚠[/] [yellow]3 warnings[/] in {fileName}");
            AnsiConsole.MarkupLineInterpolated($"[bold red]✗ Error:[/] Missing dependency '{dependency}'");
            AnsiConsole.MarkupLine("  → See: [link=https://docs.example.com/dependencies]documentation[/]");



        }
    }
}