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
int z = matchNumber - y;
Console.WriteLine($"{numberOfMatchesAfter} ({z})");
Random random = new Random();
int number = random.Next(1, 3); 
Console.WriteLine($"The AI draw {number} matches.");

string numberOfMatchesAfterAi = string.Empty;
for (int i = 0; i < 24-y-number; i++)
{
    numberOfMatchesAfterAi += x.ToString();
}

Console.WriteLine($"{numberOfMatchesAfterAi} ({z-number})");
Console.WriteLine("How many matches do you want to draw?");

