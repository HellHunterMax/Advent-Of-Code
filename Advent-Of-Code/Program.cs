// See https://aka.ms/new-console-template for more information
using Advent_Of_Code.Day1;
using Advent_Of_Code.Day2;
using Advent_Of_Code.Day2.Part2;
using Advent_Of_Code.Day3.Part1;
using Advent_Of_Code.Day3.Part2;
using Advent_Of_Code.Day4.Part1;
using Advent_Of_Code.Day5;
using Advent_Of_Code.Day6;

//Sonar sonar = new();
//NavigationPart2 navigation = new();
//LifeSupport power = new();
//Submarine submarine = new(sonar, navigation, power);

//Bingo bingo = new(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code\Day4\Input\Bingo.txt");

/*
Scanner scanner = new();
scanner.BuildFloorPlan(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code\Day5\input\Vents.txt");
int number = scanner.Floor.CountDangerousVents();
Console.WriteLine(number); 
*/
//Console.WriteLine(bingo.FindLoser());


//Console.WriteLine(bingo.FindWinner());

//submarine.PowerConsumption(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code\Day3\Input\PowerReport.txt");

//submarine.Move(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code\Day2\Input\movements.txt");

//DAY6
string input = "3,4,1,2,1,2,5,1,2,1,5,4,3,2,5,1,5,1,2,2,2,3,4,5,2,5,1,3,3,1,3,4,1,5,3,2,2,1,3,2,5,1,1,4,1,4,5,1,3,1,1,5,3,1,1,4,2,2,5,1,5,5,1,5,4,1,5,3,5,1,1,4,1,2,2,1,1,1,4,2,1,3,1,1,4,5,1,1,1,1,1,5,1,1,4,1,1,1,1,2,1,4,2,1,2,4,1,3,1,2,3,2,4,1,1,5,1,1,1,2,5,5,1,1,4,1,2,2,3,5,1,4,5,4,1,3,1,4,1,4,3,2,4,3,2,4,5,1,4,5,2,1,1,1,1,1,3,1,5,1,3,1,1,2,1,4,1,3,1,5,2,4,2,1,1,1,2,1,1,4,1,1,1,1,1,5,4,1,3,3,5,3,2,5,5,2,1,5,2,4,4,1,5,2,3,1,5,3,4,1,5,1,5,3,1,1,1,4,4,5,1,1,1,3,1,4,5,1,2,3,1,3,2,3,1,3,5,4,3,1,3,4,3,1,2,1,1,3,1,1,3,1,1,4,1,2,1,2,5,1,1,3,5,3,3,3,1,1,1,1,1,5,3,3,1,1,3,4,1,1,4,1,1,2,4,4,1,1,3,1,3,2,2,1,2,5,3,3,1,1";

var split = input.Split(',');

List<int> numbers = new();

foreach (var number in split)
{
    numbers.Add(int.Parse(number));
}

LanternFishScanner scanner = new(numbers);
scanner.AddDays(80);
Console.WriteLine(scanner.FishCount());

