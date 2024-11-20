{
    ThreadStart:
    Console.WriteLine("Give me a the radius.");
    float userInput1, userInput2;

    // First input loop
    {
        while (!float.TryParse(Console.ReadLine(), out userInput1))
        {
            Console.WriteLine("Wrong input");
        }
    }
    double PI = 3.1415926535897931;
    double areaCircle = ((userInput1*PI)*2);
    Console.WriteLine(areaCircle);
    
    goto ThreadStart;
}
    
