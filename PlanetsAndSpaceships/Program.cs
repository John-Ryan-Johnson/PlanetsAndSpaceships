using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            Console.WriteLine($"Beginning of list: {string.Join(", ", planetList)}");

            Console.WriteLine();

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            Console.WriteLine($"Used Add to add Jupiter and Saturn: {string.Join(", ", planetList)}");

            Console.WriteLine();

            List<string> lastTwoPlanetsList = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanetsList);

            Console.WriteLine($"Used AddRange to add Uranus and Neptune: {string.Join(", ", planetList)}");

            Console.WriteLine();

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            Console.WriteLine($"Inserted Venus and Earth. Added Pluto: {string.Join(", ", planetList)}");

            Console.WriteLine();

            List<string> rockyPlanetsList = new List<string>(planetList.GetRange(0, 4));

            Console.WriteLine($"Rocky planets: {string.Join(", ", rockyPlanetsList)}");

            Console.WriteLine();

            planetList.Remove("Pluto");

            Console.WriteLine($"Removed dwarf planet: {string.Join(", ", planetList)}");



        }
    }
}
