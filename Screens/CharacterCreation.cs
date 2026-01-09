using System;
using Spectre.Console;
using System.Threading;

namespace TTOTAR
    {
        class CharacterCreation
        {
            public static Player? CreateCharacter()
            {
                AnsiConsole.Clear();
                AnsiConsole.Write(new Rule("[yellow]Character Creation[/]").RuleStyle("yellow"));
                AnsiConsole.WriteLine();

                // Step 1: Get character name
                string characterName = AnsiConsole.Ask<string>("What is your character's [green]name[/]?");
                AnsiConsole.MarkupLine($"[green]Welcome, {characterName}![/]");
                AnsiConsole.WriteLine();

                // Step 2: Choose race
                var races = new[] { "Human", "Elf", "Dwarf", "Orc" };
                string selectedRace = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Choose your [green]race[/]:")
                        .AddChoices(races)
                        .UseConverter(race =>
                        {
                            // Show race stats when selecting
                            return race switch
                            {
                                "Human" => "Human (Balanced: +0 all stats)",
                                "Elf" => "Elf (Agile: +2 Dexterity, -1 Strength)",
                                "Dwarf" => "Dwarf (Sturdy: +2 Constitution, -1 Dexterity)",
                                "Orc" => "Orc (Strong: +2 Strength, -1 Intelligence)",
                                _ => race
                            };
                        }));

                DisplayHelper.ShowRaceStats(selectedRace);
                AnsiConsole.WriteLine();

                // Step 3: Choose class
                var classes = new[] { "Wizard", "Rogue", "Knight" };
                string selectedClass = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Choose your [green]class[/]:")
                        .AddChoices(classes)
                        .UseConverter(cls =>
                        {
                            return cls switch
                            {
                                "Wizard" => "Wizard (Magic damage, Low health)",
                                "Rogue" => "Rogue (High speed, Medium damage)",
                                "Knight" => "Knight (High defense, Medium damage)",
                                _ => cls
                            };
                        }));

                DisplayHelper.ShowClassStats(selectedClass);
                AnsiConsole.WriteLine();

                // Step 4: Show final character summary
                ShowCharacterSummary(characterName, selectedRace, selectedClass);

                // Confirm creation
                if (AnsiConsole.Confirm("Create this character?"))
                {
                    AnsiConsole.MarkupLine("[green]Character created successfully![/]");

                    // Create a new player object with the info
                    var player = new Player
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Class = selectedClass,
                    };

                    PlayerStats.ApplyRaceStats(player);
                    PlayerStats.ApplyClassStats(player);

                    Thread.Sleep(2000);
                    return player;  // Send the player back
                }
                else
                {
                    AnsiConsole.MarkupLine("[yellow]Returning to main menu...[/]");
                    Thread.Sleep(1500);
                    ConsoleMenu.ShowMainMenu();
                    return null;  // Return nothing if they cancelled
                }
            }


            private static void ShowRaceStats(string race)
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

            private static void ShowClassStats(string className)
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

            private static void ShowCharacterSummary(string name, string race, string className)
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