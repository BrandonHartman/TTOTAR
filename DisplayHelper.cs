using Spectre.Console;

namespace TTOTAR
{
    class DisplayHelper
    {
        public static void ShowRaceStats(string race)
        {
            var table = new Table();
            table.Border(TableBorder.Rounded);
            table.Title($"[yellow]{race} Stats[/]");
            table.AddColumn("Stat");
            table.AddColumn("Base Value");
            table.AddColumn("Bonus");

            switch (race)
            {
                case "Human":
                    table.AddRow("Strength", "10", "+0");
                    table.AddRow("Dexterity", "10", "+0");
                    table.AddRow("Constitution", "10", "+0");
                    table.AddRow("Intelligence", "10", "+0");
                    break;
                case "Elf":
                    table.AddRow("Strength", "9", "-1");
                    table.AddRow("[green]Dexterity[/]", "[green]12[/]", "[green]+2[/]");
                    table.AddRow("Constitution", "10", "+0");
                    table.AddRow("Intelligence", "10", "+0");
                    break;
                case "Dwarf":
                    table.AddRow("Strength", "10", "+0");
                    table.AddRow("Dexterity", "9", "-1");
                    table.AddRow("[green]Constitution[/]", "[green]12[/]", "[green]+2[/]");
                    table.AddRow("Intelligence", "10", "+0");
                    break;
                case "Orc":
                    table.AddRow("[green]Strength[/]", "[green]12[/]", "[green]+2[/]");
                    table.AddRow("Dexterity", "10", "+0");
                    table.AddRow("Constitution", "10", "+0");
                    table.AddRow("Intelligence", "9", "-1");
                    break;
            }

            AnsiConsole.Write(table);
        }

        public static void ShowClassStats(string className)
        {
            var table = new Table();
            table.Border(TableBorder.Rounded);
            table.Title($"[yellow]{className} Stats[/]");
            table.AddColumn("Attribute");
            table.AddColumn("Value");

            switch (className)
            {
                case "Wizard":
                    table.AddRow("Health", "50");
                    table.AddRow("Mana", "100");
                    table.AddRow("Damage", "High (Magic)");
                    table.AddRow("Defense", "Low");
                    break;
                case "Rogue":
                    table.AddRow("Health", "75");
                    table.AddRow("Mana", "50");
                    table.AddRow("Damage", "Medium");
                    table.AddRow("Defense", "Medium");
                    table.AddRow("Speed", "High");
                    break;
                case "Knight":
                    table.AddRow("Health", "100");
                    table.AddRow("Mana", "30");
                    table.AddRow("Damage", "Medium");
                    table.AddRow("Defense", "High");
                    break;
            }

            AnsiConsole.Write(table);
        }

        public static void ShowCharacterSummary(string name, string race, string className)
        {
            var panel = new Panel(
                $"[bold]Name:[/] {name}\n" +
                $"[bold]Race:[/] {race}\n" +
                $"[bold]Class:[/] {className}")
            {
                Header = new PanelHeader("[yellow]Character Summary[/]"),
                Border = BoxBorder.Double,
                BorderStyle = new Style(Color.Yellow)
            };

            AnsiConsole.Write(panel);
        }
    }
}