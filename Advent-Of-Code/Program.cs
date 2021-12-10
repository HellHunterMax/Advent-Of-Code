// See https://aka.ms/new-console-template for more information
using Advent_Of_Code.Day1;
using Advent_Of_Code.Day2;
using Advent_Of_Code.Day2.Part2;
using Advent_Of_Code.Day3.Part1;
using Advent_Of_Code.Day3.Part2;
using Advent_Of_Code.Day4.Part1;
using Advent_Of_Code.Day5;

//Sonar sonar = new();
//NavigationPart2 navigation = new();
//LifeSupport power = new();
//Submarine submarine = new(sonar, navigation, power);

//Bingo bingo = new(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code\Day4\Input\Bingo.txt");

Scanner scanner = new();

scanner.BuildFloorPlan(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code\Day5\input\Vents.txt");
int number = scanner.Floor.CountDangerousVents();
Console.WriteLine(number); 

//Console.WriteLine(bingo.FindLoser());


//Console.WriteLine(bingo.FindWinner());



//submarine.PowerConsumption(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code\Day3\Input\PowerReport.txt");

//submarine.Move(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code\Day2\Input\movements.txt");

