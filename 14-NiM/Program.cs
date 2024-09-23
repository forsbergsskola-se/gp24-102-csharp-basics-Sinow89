using System.Globalization;
Console.WriteLine("Welcome to Nim!");
int matchNumber = 24;
char x = '|';
string numberOfMatches = string.Empty;
for (int i = 0; i < 24; i++)
{
    numberOfMatches += x.ToString();
}
Console.WriteLine($"{numberOfMatches} ({matchNumber})");
Console.WriteLine("How many matches do you want to draw?");
string? userInput = Console.ReadLine();
int y = Convert.ToInt32(userInput);
string numberOfMatchesAfter = string.Empty;
for (int i = 0; i < 24-y; i++)
{
    numberOfMatchesAfter += x.ToString();
}
int z2 = matchNumber - y;
Console.WriteLine($"{numberOfMatchesAfter} ({z2})");
Console.WriteLine("The AI draws 3 matches.");