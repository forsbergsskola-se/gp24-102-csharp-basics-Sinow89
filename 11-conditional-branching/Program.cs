
Console.WriteLine("Whats your age?");
//First input start and definitions
string input = Console.ReadLine();
string age = input;
int IntAge = Convert.ToInt32(age);
bool isChild = IntAge > 0 && IntAge < 12;
bool isTeenager = IntAge > 13 && IntAge < 19;
bool isAdult = IntAge >= 20;

//first if behaviour
if (isChild) {Console.WriteLine("You are a child.");}
if (isTeenager) {Console.WriteLine("You are a teenager.");}
if (isAdult)   {Console.WriteLine("You are an adult.");}
Console.WriteLine("Give me another integer.");

//Next input start and definitions
string input2 = Console.ReadLine();
string Interger = input2;
int IntInterger = Convert.ToInt32(Interger);
bool isOdd = IntInterger < 30;
int x = IntInterger;
int y = 11;
int sum = x + y;

//second if behaviour
if (isOdd) {Console.WriteLine("The maximum is :" +sum);}
if (sum % 2 == 0) { Console.WriteLine($"Thats an even number."); } 
else { Console.WriteLine($"Thats an odd number."); } 
