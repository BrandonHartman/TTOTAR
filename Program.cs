using System;
using Spectre.Console;

/*
    TODO: Look into a TUI library
    TODO: Create a Menu system that shows title, start new game, load game, settings, exit
    TODO: Create Character Creation system with dynamic stat display and not static
    TODO: Load and Save system using JSON serialization
    TODO: Implement combat system with turn-based mechanics
    ! TODO: Add multiplayer support - Later on down the road
    TODO: Combat System - Turn based with options for attack, magic, items, flee
    TODO: Dice rolling menchanics for attacks and skill checks
    TODO: Experience and Leveling System
    TODO: Inventory System with items, equipment, and gold
    TODO: World Exploration with different locations and random encounters
    TODO: Quests and Storyline
    ! TODO: Sound effects and background music - is that possible in console apps?
    TODO: Implement unit tests for core game mechanics
    Todo: Polish and optimize codebase
    TODO: Leveling system with skill and ability improvements
    TODO: Implement saving and loading game state
    TODO: Add more detailed comments and documentation
    TODO: Create a settings menu to adjust text speed and difficulty
    TODO: Add ASCII art for title screen and important events
    TODO: Implement error handling for user inputs
    TODO: Create a help menu with game instructions
    TODO: Add more flavor text and descriptions to enhance immersion
    TODO: Implement a logging system for debugging purposes
    TODO: Create a credits screen to acknowledge contributors
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