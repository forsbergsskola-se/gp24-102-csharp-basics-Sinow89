// All the variables that will be just in the Game
 Console.WriteLine("Welcome to Nim!");
 bool isAiTurn  = false;
 Random random = new Random();
 int matches = 24;
 int minMatchesToDraw = 1;
 int maxMatchesToDraw = 3;
 char matchChar  = '|';
 string matchOutput = new string(matchChar , matches);
 Console.WriteLine($"{matchOutput} ({matches})");
 

//Start of the loop
 restartFromStart:
 switch (isAiTurn)
 {
  //This is the player segement
  case false:
   Console.WriteLine("How many matches do you want to draw?");
   string? userInput = Console.ReadLine();
   int y;
   
   while (!int.TryParse(userInput, out y) || y < minMatchesToDraw || y > maxMatchesToDraw)
   {
    Console.WriteLine("Wrong, give me a number between 1 and 3 and no characters.");
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
//-----------------------------------------------

  // This is the AI turn segement
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
 //This is where the flip of the bool happens
  isAiTurn  = !isAiTurn ;
  goto restartFromStart;
 
 // End game segement 
endGame: ;
Console.WriteLine("Game over!");

