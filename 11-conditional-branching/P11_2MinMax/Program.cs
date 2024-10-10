
{ 
    ThreadStart:
Console.WriteLine("Give me three numbers with different values.");
string? input1 = Console.ReadLine();
string? input2 = Console.ReadLine();
string? input3 = Console.ReadLine();
int intString1 = Convert.ToInt32(input1);
int intString2 = Convert.ToInt32(input2);
int intString3 = Convert.ToInt32(input3);


int min = intString1;
int max = intString1;

if (intString2 < min)
{
    min = intString2;
}
if (intString2 > max)
{
    max = intString2;
}

// Check if the third number is smaller or larger
if (intString3 < min)
{
    min = intString3;
}
if (intString3 > max)
{
    max = intString3;
}

// Output the minimum and maximum values
Console.WriteLine($"The minimum value is: {min}");
Console.WriteLine($"The maximum value is: {max}");

    goto ThreadStart;
}