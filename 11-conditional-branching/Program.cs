


Console.WriteLine("Whats your age?");
string input = Console.ReadLine();
string age = input;
int IntAge = Convert.ToInt32(age);
bool isChild = IntAge > 0 && IntAge < 12;
bool isTeenager = IntAge > 13 && IntAge < 19;
bool isAdult = IntAge >= 20;
if (isChild) {Console.WriteLine("You are a child.");}
if (isTeenager) {Console.WriteLine("You are a teenager.");}
if (isAdult)   {Console.WriteLine("You are an adult.");}
Console.WriteLine("Give me another integer.");
string input2 = Console.ReadLine();
string Interger = input2;
int IntInterger = Convert.ToInt32(Interger);
bool isOdd = IntInterger < 30;
if (isOdd) {Console.WriteLine("The maximum is :" + input2);}
