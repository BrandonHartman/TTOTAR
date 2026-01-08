using System;
using Spectre.Console;

/*
    TODO: Look into a TUI library
    TODO: Create a Menu system that shows title, start new game, load game, settings, exit
    TODO: Create Character Creation system with dynamic stat display and not static
    TODO: Load and Save system using JSON serialization
    TODO: Implement combat system with turn-based mechanics
    ! TODO: Add multiplayer support - Later on down the road

    
*/

namespace TTOTAR
{
    class Program
    {
        static void Main(string[] args)
        {

            TitleScreen.ShowGameTitle();
            ConsoleMenu.ShowMainMenu();
        }
    }
}