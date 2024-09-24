// Console.WriteLine("Welcome to Nim!");
// int matchNumber = 24;
// char x = '|';
// string numberOfMatches = string.Empty;
// for (int i = 0; i < 24; i++)
// {
//     numberOfMatches += x.ToString();
// }
// Console.WriteLine($"{numberOfMatches} ({matchNumber})");
// Console.WriteLine("How many matches do you want to draw?");
// string? userInput = Console.ReadLine();
// int y = Convert.ToInt32(userInput);
// string numberOfMatchesAfter = string.Empty;
// for (int i = 0; i < 24-y; i++)
// {
//     numberOfMatchesAfter += x.ToString();
// }
// int z = matchNumber - y;
// Console.WriteLine($"{numberOfMatchesAfter} ({z})");
// Random random = new Random();
// int number = random.Next(1, 3); 
// Console.WriteLine($"The AI draw {number} matches.");
//
// string numberOfMatchesAfterAi = string.Empty;
// for (int i = 0; i < 24-y-number; i++)
// {
//     numberOfMatchesAfterAi += x.ToString();
// }
// Console.WriteLine($"{numberOfMatchesAfterAi} ({z-number})");
// Console.WriteLine("How many matches do you want to draw?");


/*
 * bool isAi = false
 * restartFromStart:
 * print matches (24)
 * 
 * switch (isAi)
 * case true:
 * ai drar stickor, - matches
 * case false:
 * spelare drar stickor - matches
 *
 * checka stickor
 * mindre än 3 spelaren ai förlorar, anv. isAi
 * flip isAi
 * goto restartFromStart;
 * string nuOfMatches = new string('|', antal)
 */



 Console.WriteLine("Welcome to Nim!");
 bool isAiTurn  = false;
 Random random = new Random();
 int matches = 24;
 char matchChar  = '|';
 string matchOutput = new string(matchChar , matches);
 Console.WriteLine($"{matchOutput} ({matches})");
 


 restartFromStart:
 switch (isAiTurn )
 {
  case false:
   Console.WriteLine("How many matches do you want to draw?");
   string userInput = Console.ReadLine();
   int y;
   
   while (!int.TryParse(userInput, out y))
   {
    Console.WriteLine("Wrong, give me numbers.");
    userInput = Console.ReadLine();
   }
   
   matches -= y;
   matchOutput = new string(matchChar , matches);
   Console.WriteLine($"{matchOutput} ({matches})");
   
   if (matches <= 1)
   {
    Console.WriteLine("You win!");
    goto endGame;
   }
   
   break;

  case true:
   int number = random.Next(1, Math.Min(4, matches));
   matches -= number;
   Console.WriteLine($"The AI draw {number} matches.");
   matchOutput = new string(matchChar , matches);
   Console.WriteLine($"{matchOutput} ({matches})");
   if (matches <= 1)
   {
    Console.WriteLine("You Lose!");
    goto endGame;
   }
   
   break;
  
 }
 
  isAiTurn  = !isAiTurn ;
  goto restartFromStart;

endGame: ;
Console.WriteLine("Game over!");

