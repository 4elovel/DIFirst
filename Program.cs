namespace DIFirst;

internal class Program
{

    static void Main(string[] args)
    {
        List<IAnimal> list = new();
        list.Add(new Cat());
        list.Add(new Dog());
        AnimalEncrypter encrypter = new AnimalEncrypter(list, "Text.txt");
        encrypter.Encrypt();
        List<IAnimal> list2 = encrypter.Decrypt();
        foreach (IAnimal animal in list2)
        {
            animal.PrintName();
            animal.PrintSound();
        }

        FigureEncrypter encrypter2 = new FigureEncrypter(new List<IFigure>() { new Triangle(), new Rectangle() }, "Text2.txt");
        encrypter2.Encrypt();
        encrypter2.ClearList();
        encrypter2.ChangeList(encrypter2.Decrypt());
        foreach (IFigure figure in encrypter2.GetList())
        {
            figure.PrintName();
            figure.PrintVisualisation();
        }

    }
}
