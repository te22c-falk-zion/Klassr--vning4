public class grafikkort(string n, int v) : Hardware(n,v)
{
    private int gen;

    public int GetGen(int g)
    {
        return gen;
    }
    public void SetGen()
    {
        string genString = "a";

        Console.WriteLine($"Type what number gen you want");
        genString = Console.ReadLine();
        while(!genString.All(char.IsDigit))
        {
            Console.WriteLine("Input number");
            genString = Console.ReadLine();
        }
        int.TryParse(genString, out gen);
        Console.WriteLine($"Your graphics gen is {gen}");
    }
}