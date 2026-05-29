using System;

class Program
{
    static void Main()
    {
        Kat kat1 = new Kat("Luna", 3);

        kat1.Miauw();
    }
}

public class Kat
{
    public string Naam { get; set; }
    public int Leeftijd { get; set; }

    public Kat(string naam, int leeftijd)
    {
        Naam = naam;
        Leeftijd = leeftijd;
    }

    public void Miauw()
    {
        Console.WriteLine($"{Naam} zegt: Miauw!");
    }

    public void Eet()
{
    Console.WriteLine($"{Naam} is aan het eten.");
}
}