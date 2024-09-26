{
    ThreadStart:
Console.WriteLine("How many points did you get?");
string? input = Console.ReadLine();
int intString = Convert.ToInt32(input);

    if (intString <= 59)
    {
        Console.WriteLine("F!");
    }
    else if (intString <=69 && intString > 60) {
        Console.WriteLine("D!"); } 
    
    else if (intString <=79 && intString > 70) {
        Console.WriteLine("C!");
    }
    else if (intString <=89 && intString > 80) {
        Console.WriteLine("B!");
    }
    else if (intString <=100 && intString > 90) {
        Console.WriteLine("A!");
    }
    
    goto ThreadStart;
}