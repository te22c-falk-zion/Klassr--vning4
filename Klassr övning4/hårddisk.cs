public class hårddisk(string n, int v) : Hardware(n,v)
{
    private int storage;

    public int GetStorage()
    {
        return storage;
    }

    public void SetStorage()
    {
        string storageString = "a";

        Console.WriteLine($"Type how much storage you want");
        storageString = Console.ReadLine();
        while(!storageString.All(char.IsDigit))
        {
            Console.WriteLine("Input number");
            storageString = Console.ReadLine();
        }
        int.TryParse(storageString, out storage);
        Console.WriteLine($"Your disk space is now {storage}");
    }
}