{
    ThreadStart:
    Console.WriteLine("Give me a your weight in kilos and your height in meters");
    double userInput1, userInput2;

    // First input loop
    {
        while (!double.TryParse(Console.ReadLine(), out userInput1))
        {
            Console.WriteLine("Wrong input");
        }
    }
    // Second input loop
    {
        while (!double.TryParse(Console.ReadLine(), out userInput2))
        {
            Console.WriteLine("Wrong input");
        }
    }
    //The division result of the two inputs
    double bmi = (userInput1 / (userInput2*userInput2));
    Console.WriteLine(bmi);
    
    goto ThreadStart;
}
    
