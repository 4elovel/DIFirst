namespace DIFirst;

internal class FigureEncrypter
{
    List<IFigure> ls;
    string path;
    public FigureEncrypter(List<IFigure> ls, string path)
    {
        this.ls = ls;
        this.path = path;
    }
    public void Encrypt()
    {
        using (StreamWriter outputFile = new StreamWriter(path))
        {
            outputFile.Write("{");
            foreach (IFigure an in ls)
            {
                Type type = an.GetType();
                outputFile.Write(type.FullName);
                outputFile.Write(",");
            }
            outputFile.Write("}");
        }
    }
    public List<IFigure> Decrypt()
    {
        List<IFigure> res = new();
        string text = File.ReadAllText(path);
        char[] separators = new char[] { ',', '{', '}' };
        string[] textList = text.Split(separators);
        foreach (var i in textList)
        {
            if (i != "")
            {
                Type type = Type.GetType(i);
                res.Add((IFigure)Activator.CreateInstance(type));
            }
        }

        return res;
    }
    public void ClearList() { ls.Clear(); }
    public void ChangeList(List<IFigure> ls) { this.ls = ls; }
    public List<IFigure> GetList() { return ls; }
}
