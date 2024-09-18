Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");
AskToBuy:
string? answer = Console.ReadLine();
double intAnswer = Convert.ToDouble(answer);

if (answer == "42") 
    
{ Console.WriteLine("That's the number! Well played!"); }

else if (intAnswer <42)  { Console.WriteLine("Nope! My number is Greater!"); }
else if (intAnswer >42)  { Console.WriteLine("Nope! My number is Smaller!"); }

{ goto AskToBuy; }
Console.WriteLine("Thanks for buying my game!");