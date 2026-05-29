using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Kat> katten = new List<Kat>()
        {
            new Kat("Luna", 3),
            new Kat("Milo", 5),
            new Kat("Simba", 2)
        };

        foreach (Kat kat in katten)
        {
            Console.WriteLine($"Naam: {kat.Naam}, Leeftijd: {kat.Leeftijd}");

            kat.Miauw();
            kat.Eet();
            kat.Slaap();

            Console.WriteLine();
        }
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

    public void Slaap()
    {
        Console.WriteLine($"{Naam} is aan het slapen.");
    }
}