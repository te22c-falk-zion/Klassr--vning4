using System.Runtime.ExceptionServices;

string hadrwareString = "a";
int hardwareInt;
bool picking = true;
List<Hardware> hardwares = new List<Hardware>(); 
while (picking == true)
{
Console.WriteLine("YOoo spec time");
Console.WriteLine($"0.Procesor\n1.Harddrive\n2.Graphic card\n3.Exit");
hadrwareString = Console.ReadLine();
int.TryParse(hadrwareString, out hardwareInt);

while (!hadrwareString.All(char.IsDigit) || hardwareInt >= 4)
{
    Console.Clear();
    Console.WriteLine("Input a number to select hardware");
    Console.WriteLine($"0.Procesor\n1.Harddrive\n2.Graphic card\n3.Exit");
    hadrwareString = Console.ReadLine();
    int.TryParse(hadrwareString, out hardwareInt);
}


if (hardwareInt == 0)
{
    string cpuName = "";
    int pvalueInt;
    string pvalueString = "a";
    Console.WriteLine($"What is the name of your proccesor?");
    cpuName = Console.ReadLine();
    while(!pvalueString.All(char.IsDigit))
    {
        Console.WriteLine($"What is the value of your proccesor?");
        pvalueString = Console.ReadLine();
    }
    int.TryParse(pvalueString, out pvalueInt);
    processor p = new processor(cpuName, pvalueInt);
    p.SetCores();
    p.SetHz();
    hardwares.Add(p);
    Console.WriteLine($"Succesfully made and added into list");
    Console.ReadLine();
}
if (hardwareInt == 1)
{
        string hårddiskName = "";
    int hvalueInt;
    string hvalueString = "a";
    Console.WriteLine($"What is the name of your harddrive?");
    hårddiskName = Console.ReadLine();
    while(!hvalueString.All(char.IsDigit))
    {
        Console.WriteLine($"What is the value of your harddrive?");
        hvalueString = Console.ReadLine();
    }
    int.TryParse(hvalueString, out hvalueInt);
    hårddisk h = new hårddisk(hårddiskName, hvalueInt);
    h.SetStorage();
    hardwares.Add(h);
    Console.WriteLine($"Succesfully made and added into list");
    Console.ReadLine();
}
if (hardwareInt == 2)
{
    string grafikName = "";
    int gvalueInt;
    string gvalueString = "a";
    Console.WriteLine($"What is the name of your graphic card?");
    grafikName = Console.ReadLine();
    while(!gvalueString.All(char.IsDigit))
    {
        Console.WriteLine($"What is the value of your graphic card?");
        gvalueString = Console.ReadLine();
    }
    int.TryParse(gvalueString, out gvalueInt);
    grafikkort g = new grafikkort(grafikName, gvalueInt);
    g.SetGen();
    hardwares.Add(g);
    Console.WriteLine($"Succesfully made and added into list");
    Console.ReadLine();
}
if (hardwareInt == 3)
{
    picking = false;
}
}
