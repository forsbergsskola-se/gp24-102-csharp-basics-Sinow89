
Console.WriteLine("Give me a two numbers.");
int userInput;
while (!int.TryParse(Console.ReadLine(), out userInput))
{
    Console.WriteLine("Wrong input");
}

double division = (userInput);
division = Math.Floor(division*10);
Console.WriteLine(division);

    
