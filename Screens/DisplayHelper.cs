using Spectre.Console;

namespace TTOTAR
{
    class DisplayHelper
    {
        #region Theme Colors
        public static Color PrimaryColor = Color.Gold1;
        public static Color SuccessColor = Color.Green1;
        public static Color WarningColor = Color.Orange3;
        public static Color DangerColor = Color.Red1;
        public static Color InfoColor = Color.Cyan1;
        public static Color MutedColor = Color.Grey;

        // Rarity Colors
        public static Color CommonColor = Color.Grey;
        public static Color UncommonColor = Color.Green;
        public static Color RareColor = Color.Blue;
        public static Color EpicColor = Color.Purple;
        public static Color LegendaryColor = Color.Orange1;

        public static string PrimaryMarkup = "[gold1]";
        public static string SuccessMarkup = "[green1]";
        public static string WarningMarkup = "[orange1]";
        public static string DangerMarkup = "[red1]";
        public static string InfoMarkup = "[cyan1]";
        public static string MutedMarkup = "[grey]";

        #endregion

        #region Border Styles
        public static TableBorder StandardTableBorder = TableBorder.Rounded;
        public static BoxBorder StandardBoxBorder = BoxBorder.Rounded;

        public static BoxBorder ImportantPanelBorder = BoxBorder.Double;
        public static TableBorder CombatTableBorder = TableBorder.HeavyHead;
        #endregion

        public static string GetRarityColor(string rarity)
        {
            return rarity switch
            {
                "Common" => "[grey]",
                "Uncommon" => "[green]",
                "Rare" => "[blue]",
                "Epic" => "[purple]",
                "Legendary" => "[orange1]",
                _ => "[grey]"  // Default
            };
        }
        public static string GetItemIcon(object item)
        {
            if (item is Weapon)
            {
                return "⚔️";  // Sword icon for weapons
            }
            else if (item is Armor)
            {
                return "🛡️";  // Shield icon for armor
            }
            else
            {
                return "📦";  // Box icon for unknown items
            }
        }


        public static void ShowRaceStats(string race)
        {
            var table = new Table();
            table.Border(TableBorder.Rounded);
            table.Title($"{PrimaryMarkup}{race} Stats[/]");
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
                    table.AddRow($"{SuccessMarkup}Dexterity[/]", $"{SuccessMarkup}12[/]", $"{SuccessMarkup}+2[/]");
                    table.AddRow("Constitution", "10", "+0");
                    table.AddRow("Intelligence", "10", "+0");
                    break;
                case "Dwarf":
                    table.AddRow("Strength", "10", "+0");
                    table.AddRow("Dexterity", "9", "-1");
                    table.AddRow($"{SuccessMarkup}Constitution[/]", $"{SuccessMarkup}12[/]", $"{SuccessMarkup}+2[/]");
                    table.AddRow("Intelligence", "10", "+0");
                    break;
                case "Orc":
                    table.AddRow($"{SuccessMarkup}Strength[/]", $"{SuccessMarkup}12[/]", $"{SuccessMarkup}+2[/]");
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
            table.Title($"{PrimaryMarkup}{className} Stats[/]");
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
                Header = new PanelHeader($"{PrimaryMarkup}Character Summary[/]"),
                Border = BoxBorder.Double,
                BorderStyle = new Style(PrimaryColor)
            };

            AnsiConsole.Write(panel);
        }
    }
}