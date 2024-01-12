namespace DIFirst;

internal class AnimalEncrypter
{
    List<IAnimal> ls;
    string path;
    public AnimalEncrypter(List<IAnimal> ls, string path)
    {
        this.ls = ls;
        this.path = path;
    }
    public void Encrypt()
    {
        using (StreamWriter outputFile = new StreamWriter(path))
        {
            outputFile.Write("{");
            foreach (IAnimal an in ls)
            {
                Type type = an.GetType();
                outputFile.Write(type.FullName);
                outputFile.Write(",");
            }
            outputFile.Write("}");
        }
    }
    public List<IAnimal> Decrypt()
    {
        List<IAnimal> res = new();
        string text = File.ReadAllText(path);
        char[] separators = new char[] { ',', '{', '}' };
        string[] textList = text.Split(separators);
        foreach (var i in textList)
        {
            if (i != "")
            {
                Type type = Type.GetType(i);
                res.Add((IAnimal)Activator.CreateInstance(type));
            }
        }

        return res;
    }
    public void ClearList() { ls.Clear(); }
    public void ChangeList(List<IAnimal> ls) { this.ls = ls; }
    public List<IAnimal> GetList() { return ls; }

}
