Start:

Console.WriteLine("Give me a number of seconds");
string? userInput = Console.ReadLine();
int x;
while (!int.TryParse(userInput, out x))
{
    Console.WriteLine("Wrong, give me numbers.");
    userInput = Console.ReadLine();
}

int secRemain = x % 60;
int minRemain = (x/60) % 60;
int hourRemain = (x/3600) % 24;
int dayRemain = (x/3600) / 24;
Console.WriteLine("Seconds: " + secRemain);
Console.WriteLine("Minutes: " + minRemain);
Console.WriteLine("Hours: " + hourRemain);
Console.WriteLine("Days: " + dayRemain);

Console.WriteLine($"{dayRemain}.{hourRemain}:{minRemain}:{secRemain}");

Console.WriteLine("In total, that's " + ((double)x/86400) + " Days");


goto Start;



