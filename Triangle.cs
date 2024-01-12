namespace DIFirst;

internal class Triangle : IFigure
{
    public void PrintName()
    {
        Console.WriteLine("I am triangle");
    }

    public void PrintVisualisation()
    {
        Console.WriteLine("     *");
        Console.WriteLine("    * *");
        Console.WriteLine("   *   *");
        Console.WriteLine("  *     *");
        Console.WriteLine(" *       *");
        Console.WriteLine("***********");
    }
}
