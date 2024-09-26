{
    ThreadStart:
    Console.WriteLine("Give me a number.");
    float userInput1, userInput2;

    // First input loop
    {
        while (!float.TryParse(Console.ReadLine(), out userInput1))
        {
            Console.WriteLine("Wrong input");
        }
    }
    
    float negation  = (userInput1*-1);
    Console.WriteLine(negation);
    
    goto ThreadStart;
}
    
