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
        Console.WriteLine($"{Name} says: Meow! 🐾");
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
