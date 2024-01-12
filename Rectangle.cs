namespace DIFirst;

internal class Rectangle : IFigure
{
    public void PrintName()
    {
        Console.WriteLine("I am rectangle");
    }

    public void PrintVisualisation()
    {
        Console.WriteLine("****************");
        Console.WriteLine("*              *");
        Console.WriteLine("*              *");
        Console.WriteLine("*              *");
        Console.WriteLine("*              *");
        Console.WriteLine("****************");
    }
}
