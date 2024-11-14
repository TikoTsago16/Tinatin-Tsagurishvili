using System;

interface IAnimal
{
    string MakeSound();
}


abstract class Animal : IAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // MakeSound is implementacia
    public abstract string MakeSound();
}

// shevkmna animal klasis memkvidre Dog class, romelic MakeSoundis meshveobit daabrunebs xmas
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override string MakeSound()
    {
        return "woof";
    }
}

class Cat : Animal
{
    public Cat(string name, int age ) : base(name, age) { }

    public override string MakeSound()
    {
        return "miu";
    }
}

class Cow : Animal
{
    public Cow(string name, int age) : base(name, age) { }

    public override string MakeSound()
    {
        return "Moo";
    }
}

class Program
{
    static void Main()
    {
        // davamate IAnimalebis masivi , romelshic saxelebi da asakebi gavuwere
        IAnimal[] animals = new IAnimal[]
        {
            new Dog("Loki", 7),
            new Cat("Pavle", 1),
            new Cow("Bocho", 32) 
        };
       
       
        foreach (var animal in animals)
        {            
            Console.WriteLine($"{animal.GetType().Name} says: {animal.MakeSound()}");
        }
    }
}
