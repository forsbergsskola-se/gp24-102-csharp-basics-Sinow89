
Console.WriteLine("This program converts minutes to seconds.");
Console.WriteLine("Give me a input of minutes please.");
int userInput;
while (!int.TryParse(Console.ReadLine(), out userInput))
{
    Console.WriteLine("Wrong input");
}

double meterSecond = (userInput*60);
meterSecond = Math.Floor(meterSecond*1);
Console.WriteLine(meterSecond);

    
