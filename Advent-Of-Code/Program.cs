// See https://aka.ms/new-console-template for more information
using Advent_Of_Code.Day1;
using Advent_Of_Code.Day2;
using Advent_Of_Code.Day2.Part2;
using Advent_Of_Code.Day3.Part1;

Sonar sonar = new();
NavigationPart2 navigation = new();
PowerPart1 power = new();
Submarine submarine = new(sonar, navigation, power);

submarine.PowerConsumption(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code\Day3\Input\PowerReport.txt");

//submarine.Move(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code\Day2\Input\movements.txt");

