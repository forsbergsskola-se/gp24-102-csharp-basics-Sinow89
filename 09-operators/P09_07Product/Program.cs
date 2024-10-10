{
    ThreadStart:
    Console.WriteLine("Give me a two numbers.");
    float userInput1, userInput2;

    // First input loop
    {
        while (!float.TryParse(Console.ReadLine(), out userInput1))
        {
            Console.WriteLine("Wrong input");
        }
    }
    // Second input loop
    {
        while (!float.TryParse(Console.ReadLine(), out userInput2))
        {
            Console.WriteLine("Wrong input");
        }
    }
    //The division result of the two inputs
    float multiplication = (userInput1 * userInput2);
    Console.WriteLine(multiplication);
    
    goto ThreadStart;
}
    
