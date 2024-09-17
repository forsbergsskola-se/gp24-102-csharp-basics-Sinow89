//First input start and definitions
Console.WriteLine("Please pass me a seed (integer)");
string? Seed = Console.ReadLine();
int IntSeed = Convert.ToInt32(Seed);

//Random 
Random random = new Random(IntSeed);
int number = random.Next(0, 5);
int number2 = random.Next(0, 5);
int number3 = random.Next(0, 5);

//Writes the random numbers
Console.WriteLine("Three integers between 0 and 5:");
Console.WriteLine(number);
Console.WriteLine(number2);
Console.WriteLine(number3);
