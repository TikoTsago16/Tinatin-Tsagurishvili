using System;

class Person
{
  
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        //main metodshi shevkmeni saxelis da asakis cvladebi da davamate person1 is saxit axali obiekti
        string name = "Tiko";
        int age = 38;

       
        Person person1 = new Person();

        //manamde shekmnili asakis da saxelis cvladebi sheinaxeba peronis klasis obieqtshi perso1
        person1.Name = name;
        person1.Age = age;

        // davamate meore obiekti person2 da masac shevukmeni saxelis da asakis cvladebi
       Person person2 = person1;

        
        person2.Name = "Nana";
        person2.Age = 65;

 
        Console.WriteLine($"Person 1: {person1.Name}, {person1.Age}"); //obiekti ki tikoa mara aqac unda dabejdos meore obieqti nana
        Console.WriteLine($"Person 2: {person2.Name}, {person2.Age}"); // nana, 65
    }
}
