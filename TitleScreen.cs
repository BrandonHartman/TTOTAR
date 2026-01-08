using System;
using Spectre.Console;

namespace TTOTAR
{
    class TitleScreen
    {
        public static void ShowGameTitle()
        {
            AnsiConsole.Clear();
            var gameTitle = new FigletText("The Tales of the Ashen Realm")
                .Centered()
                .Color(Color.Green);
            AnsiConsole.Write(gameTitle);
            var version = new FigletText("RELEASE v0.1")
            {
                Color = Color.Green,
                Justification = Justify.Center
                
            };
            AnsiConsole.Write(new Rule().RuleStyle(Style.Parse("green dim")));
            AnsiConsole.Write(version);
            AnsiConsole.Write(new Rule().RuleStyle(Style.Parse("green dim")));
        }
    }
}