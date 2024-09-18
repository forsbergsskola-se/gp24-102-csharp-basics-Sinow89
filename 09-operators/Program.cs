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
float x = Convert.ToInt32(seconds);
float y = x / 60; //How many minutes
float z = y / 60; // How many hours
float w = z / 24; //How many days
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(w);

