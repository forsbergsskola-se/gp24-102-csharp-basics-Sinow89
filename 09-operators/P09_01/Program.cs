
int userInput;
while (!int.TryParse(Console.ReadLine(), out userInput))
{
    Console.WriteLine("Wrong input");
}

double meterSecond = (userInput*0.2777777777778);
meterSecond = Math.Floor(meterSecond*1);
Console.WriteLine(meterSecond);

    
