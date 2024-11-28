public class Hardware(string n, int v) 
{
    protected string name = n;
    protected int value = v;

    public int GetValue()
    {
        return value;
    }
    public string GetName()
    {
        return name;
    }
}