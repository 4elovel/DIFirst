namespace DIFirst;

internal class Dog : IAnimal
{

    public void PrintName()
    {
        Console.WriteLine("I am dog");
    }

    public void PrintSound()
    {
        Console.WriteLine("I say woof");
    }
}
