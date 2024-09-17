//First input start and definitions
Console.WriteLine("Please pass me a seed (integer)");
string? seed = Console.ReadLine();
int intSeed = Convert.ToInt32(seed);

//Random 1
Random random = new Random(intSeed);
int number = random.Next(0, 5);
int number2 = random.Next(0, 5);
int number3 = random.Next(0, 5);

//Writes the random numbers 1
Console.WriteLine("Three integers between 0 and 5:");
Console.WriteLine(number);
Console.WriteLine(number2);
Console.WriteLine(number3);

//Random 2
double doubleNumber = random.NextDouble()*0.5;
double doubleNumber2 = random.NextDouble()*0.5;
double doubleNumber3 = random.NextDouble()*0.5;

//Writes the random numbers 2
Console.WriteLine("Three numbers between 0.0 and 0.5");
Console.WriteLine(doubleNumber);
Console.WriteLine(doubleNumber2);
Console.WriteLine(doubleNumber3);

//Random 3
double doubleNumber4 = random.NextDouble()*(0.7-0.2)+0.2;
double doubleNumber5 = random.NextDouble()*(0.7-0.2)+0.2;
double doubleNumber6 = random.NextDouble()*(0.7-0.2)+0.2;

//Writes the random numbers 3
Console.WriteLine("Three numbers between 0.2 and 0.7");
Console.WriteLine(doubleNumber4);
Console.WriteLine(doubleNumber5);
Console.WriteLine(doubleNumber6);

//Critical 
Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
string? critical = Console.ReadLine();