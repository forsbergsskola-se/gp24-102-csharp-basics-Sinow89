{
    ThreadStart:
    Console.WriteLine("Give me the length and height of the triangle");
    double length, height;

    // First input loop
    {
        while (!double.TryParse(Console.ReadLine(), out length))
        {
            Console.WriteLine("Wrong input");
        }
    }
    // Second input loop
    {
        while (!double.TryParse(Console.ReadLine(), out height))
        {
            Console.WriteLine("Wrong input");
        }
    }
    //The division result of the two inputs
    
    double x = ((length*length) + (height*height));
    double hypotenuse = Math.Sqrt(x);
    Console.WriteLine("The hypotenuse is :" + hypotenuse);
    
    goto ThreadStart;
}
    
