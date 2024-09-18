Console.WriteLine("Give me a number of seconds");
string? userInput = Console.ReadLine();
int x = Convert.ToInt32(userInput);
double y = Convert.ToDouble(userInput);

int modulo = x % 60;
int modulo2 = (x/60) % 60;
int modulo3 = (x/3600) % 24;
int modulo4 = (x/3600) / 24;

Console.WriteLine("Seconds: " + modulo);
Console.WriteLine("Minutes: " + modulo2);
Console.WriteLine("Hours: " + modulo3);
Console.WriteLine("Days: " + modulo4);

Console.WriteLine($"{modulo4}.{modulo3}:{modulo2}:{modulo}");

Console.WriteLine("In total, that's " + (y/86400) + " Days");






