// using System;
// using System.Diagnostics;
//
// class Program
// {
//     static void Main()
//     {
//         Stopwatch stopwatch = new Stopwatch();
//
//         // Start the stopwatch
//         stopwatch.Start();
//
//         // Loop 400 times
//         for (int i = 0; i < 400; i++)
//         {
//             Console.Write("{0} ", i);
//         }
//
//         // Stop the stopwatch
//         stopwatch.Stop();
//
//         // Get the number of ticks (the smallest measurable time unit)
//         long ticks = stopwatch.ElapsedTicks;
//
//         // Convert ticks to microseconds
//         double microseconds = (ticks * 1_000_000.0) / Stopwatch.Frequency;
//
//         // Output the elapsed time in microseconds
//         Console.WriteLine($"Time taken: {microseconds} µs");
//     }
// }

string[,] grid = new string[5,5];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        grid[i, j] = "0";
    }
}

while (true)
{
    Console.Write("Y:");
    for (int i = 4; i >= 0; i--)
    {
        Console.WriteLine();
        Console.Write($"{i}");
        for (int j = 0; j < 5; j++)
        {
            Console.Write(" " + grid[i,j]);
        }
    }
    Console.WriteLine();
    Console.WriteLine(" 0 1 2 3 4 :X");
    
    Console.WriteLine("Give me an x coordinate");
    int x = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Give me a y coordinate");
    int y = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Give me a symbol");
    string symbol = Console.ReadLine();

    grid[y, x] = symbol;
}