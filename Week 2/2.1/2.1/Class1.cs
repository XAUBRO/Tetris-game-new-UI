using System;

public class Animal
{
    public string Species { get; set; }

    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Mammal : Animal
{
    public bool HasFur { get; set; }
}

public class Bird : Animal
{
    public bool CanFly { get; set; }
}

public class Dog : Mammal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Cat : Mammal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows.");
    }
}

public class Parrot : Bird
{
    public override void MakeSound()
    {
        Console.WriteLine("The parrot squawks.");
    }
}
