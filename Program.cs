namespace Prosjekt_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string myWord = "Word";
        Console.WriteLine(myWord);
        string expectedName = "Anders";
        string? name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
        if (name == expectedName)
        {
        Console.WriteLine("Welcome Anders");
        }
        else
        {
        Console.WriteLine("Invalid user");
        }
    }
}
