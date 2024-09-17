AskToBuy:
Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");
string answer = Console.ReadLine();
double intAnswer = Convert.ToDouble(answer);
if (answer != "42")
{
    goto AskToBuy;
}
Console.WriteLine("Thanks for buying my game!");