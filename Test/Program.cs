public class Person
{
    public string Name;
    public int Age;
    public string Gender;

    // Constructor: initializes the Person object
    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}

// Using the constructor
class Program
{
    static void Main()
    {
        // Creating a new Person object, calling the constructor
        Person person1 = new Person("John", 25, "male");
        
        Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}, Gender: {person1.Gender}");
    }
}