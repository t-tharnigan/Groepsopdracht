using System;

class Program
{
    static void Main()
    {
        CoolCat myCat = new CoolCat("Whiskers", "Orange");
        myCat.Meow();
        myCat.DisplayInfo();
        myCat.ShowAsciiArt();
    }
}

class CoolCat
{
    public string Name { get; set; }
    public string Color { get; set; }
    private int MeowCount = 0;

    public CoolCat(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public void Meow()
    {
        MeowCount++;
        string[] meows = { "Meow!", "Miauw!", "Purrrr...", "Meow meow meow!" };
        Random random = new Random();
        Console.WriteLine($"{Name} says: {meows[random.Next(meows.Length)]}");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"\n🐱 Cat Info:");
        Console.WriteLine($"   Name: {Name}");
        Console.WriteLine($"   Color: {Color}");
        Console.WriteLine($"   Meows so far: {MeowCount}");
    }

    public void ShowAsciiArt()
    {
        Console.WriteLine($"\n{Name} says:");
        Console.WriteLine(@"
   /\_/\
  ( o.o )
   > ^ <
  /|   |\
 (_|   |_)
        ");
    }
}
