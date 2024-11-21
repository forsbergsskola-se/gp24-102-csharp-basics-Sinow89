
class Program
{

    public class Character
    {
        
        public string Name { get; private set; }

        public Character(string name)
        {
            Name = name;
        }
        public void specialAttack(List<Character> characters, Func<bool> predicate)
        {
            foreach (var character in characters)
            {
                if (predicate()) 
                {
                    Console.WriteLine($"{character.Name} performs a special attack!");
                }
                else
                {
                    Console.WriteLine($"{character.Name} cannot perform a special attack.");
                }
            }
        }
    }
    
    static void Main()
    {
        Random rnd = new Random();
        Character character1 = new Character("Adam");
        Character character2 = new Character("Kalle");
        Character character3 = new Character("Lisa");
        int AttackChance = 5;

        List<Character> characters = new List<Character> { character1, character2, character3 };
       
        character1.specialAttack(characters, () => AttackChance < rnd.Next(1, 10));
        character1.specialAttack(characters, () => AttackChance < rnd.Next(1, 7));
    }
} 
    



    
