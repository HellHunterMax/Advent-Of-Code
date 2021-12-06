// See https://aka.ms/new-console-template for more information
using Advent_Of_Code.Day1;
using Advent_Of_Code.Day2;

Sonar sonar = new();
Navigation navigation = new();
Submarine submarine = new(sonar, navigation);

submarine.Move(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code\Day2\Input\movements.txt");

