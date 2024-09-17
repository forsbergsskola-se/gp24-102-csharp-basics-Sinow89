


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

