public class processor(string n, int v) : Hardware(n,v)
{
    private int cores;
    private float hz;

    public int GetCores()
    {
        return cores;
    }
    public float GetHz()
    {
        return hz;
    }
    public void SetCores()
    {
        string coresString = "a";

        Console.WriteLine($"Type what number cores you want");
        coresString = Console.ReadLine();
        while(!coresString.All(char.IsDigit))
        {
            Console.WriteLine("Input number");
            coresString = Console.ReadLine();
        }
        int.TryParse(coresString, out cores);
        Console.WriteLine($"Your core amount is now {cores}");
    }
    public void SetHz()
    {
        string hzString = "a";

        Console.WriteLine($"Type what hz you want");
        hzString = Console.ReadLine();
        while(!hzString.All(char.IsDigit))
        {
            Console.WriteLine("Input number");
            hzString = Console.ReadLine();
        }
        float.TryParse(hzString, out hz);
        Console.WriteLine($"Your hz is now {hz}");
    }
}