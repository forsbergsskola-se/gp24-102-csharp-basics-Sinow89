//Create a Console Project named P10Boolean How To?
//    Ask the user for his age. Save it to a variable named age
//    First, do a few age-checks:
//Save to a bool-variable named isChild, whether the age is between 0 and 12
//Save to a bool-variable named isTeenager, whether the age is between 13 and 19
//Save to a bool-variable named isAdult, whether the age is greater 19
//Then, print them all to the console like this:
//You are a child: True etc. (see sample below)

Console.WriteLine("Whats your age?");
string input = Console.ReadLine();
string age = input;
int IntAge = Convert.ToInt32(age);
bool isChild = IntAge > 0 && IntAge < 12;
bool isTeenager = IntAge > 13 && IntAge < 19;
bool isAdult = IntAge >= 20;
Console.WriteLine("You are a child: " + isChild);
Console.WriteLine("You are a teenager: " +isTeenager);
Console.WriteLine("You are an adult: " + isAdult);