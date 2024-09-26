{
    ThreadStart:
    Console.WriteLine("Give me seconds so I can covert it for you");
    int seconds;

    // First input loop
    {
        while (!int.TryParse(Console.ReadLine(), out seconds))
        {
            Console.WriteLine("Wrong input");
        }
    }

    //The seconds result of the two inputs
    
    int minutes = seconds/60;
    int remainders = seconds % 60;
    Console.WriteLine($"{minutes} minute(s) and {remainders} second(s)");
    
    goto ThreadStart;
}
    
