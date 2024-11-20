{
    ThreadStart:
    Console.WriteLine("Give me a number.");
    int userInput;

    // First input loop
    {
        while (!int.TryParse(Console.ReadLine(), out userInput))
        {
            Console.WriteLine("Wrong input");
        }
    }
        int result = -userInput;
        Console.WriteLine(result);
        
    goto ThreadStart;
}
    
