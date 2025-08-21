using System;

interface IAnimal
{
    void Speak();
}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

class Program
{
    static void Main()
    {
        IAnimal[] animals = new IAnimal[1];
        animals[0] = new Dog();

        animals[0].Speak();  // Dog says Woof!
    }
}
