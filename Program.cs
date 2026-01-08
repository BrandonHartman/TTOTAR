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

            TitleScreen.ShowGameTitle();
            ConsoleMenu.ShowMainMenu();



        }
    }
}