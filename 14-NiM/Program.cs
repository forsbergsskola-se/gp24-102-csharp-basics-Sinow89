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
Console.ReadLine();
