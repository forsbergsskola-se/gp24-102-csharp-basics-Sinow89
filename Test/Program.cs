using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();

        // Start the stopwatch
        stopwatch.Start();

        // Loop 400 times
        for (int i = 0; i < 400; i++)
        {
            Console.Write("{0} ", i);
        }

        // Stop the stopwatch
        stopwatch.Stop();

        // Get the number of ticks (the smallest measurable time unit)
        long ticks = stopwatch.ElapsedTicks;

        // Convert ticks to microseconds
        double microseconds = (ticks * 1_000_000.0) / Stopwatch.Frequency;

        // Output the elapsed time in microseconds
        Console.WriteLine($"Time taken: {microseconds} µs");
    }
}