// Output:Give me a number of seconds
// Input:123456
// Output:Seconds: 36
// Output:Minutes: 17
// Output:Hours: 10
// Output:Days: 1
// Output:1.10:17:36
// Output:In total, that's 1,4288888888888887 Days.

Console.WriteLine("Give me a number of seconds");
string? seconds = Console.ReadLine();
int x = Convert.ToInt32(seconds);
// float y = x / 60; //How many minutes
// float z = y / 60; // How many hours
// float w = z / 24; //How many days
int modulo = x % 60; // 2057,6
int modulo2 = (x/60) % 60; // 34,29333
int modulo3 = (x/3600) % 24; // 1,4288
int modulo4 = (x/3600) / 24;

Console.WriteLine("Seconds: " + modulo);
Console.WriteLine("Minutes: " + modulo2);
Console.WriteLine("Hours: " + modulo3);
Console.WriteLine("Days: " + modulo4);


