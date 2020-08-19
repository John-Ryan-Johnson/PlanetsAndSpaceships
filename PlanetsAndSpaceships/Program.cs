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

            Console.WriteLine();


            var planetProbes = new Dictionary<string, List<string>>();

            var mercuryProbes = new List<string> { "Mariner 10", "Messenger" };
            var venusProbes = new List<string> { "Mariner 2", "Mariner 5", "Mariner 10", "Pioneer Venus Orbiter", "Pioneer Venus Multiprobe", "Galileo", "Magellan", "Cassini", "Messenger", "Parker Solar Probe" };
            var marsProbes = new List<string> { "Mariner 4", "Mariner 6", "Mariner 7", "Mariner 9", "Mars 2", "Mars 3", "Mars 5", "Mars 6", "Mars 7" };
            var jupiterProbes = new List<string> { "Pioneer 10", "Pioneer 11", "Voyager 1", "Voyager 2", "Galileo", "Ulysses", "Cassini", "New Horizons" };
            var saturnProbes = new List<string> { "Pioneer 11", "Voyager 1", "Voyager 2", "Cassini"};
            var uranusProbes = new List<string> { "Voyager 2" };
            var neptuneProbes = new List<string> { "Voyager 2" };

            planetProbes.Add("Mercury", mercuryProbes);
            planetProbes.Add("Venus", venusProbes);
            planetProbes.Add("Mars", marsProbes);
            planetProbes.Add("Jupiter", jupiterProbes);
            planetProbes.Add("Saturn", saturnProbes);
            planetProbes.Add("Uranus", uranusProbes);
            planetProbes.Add("Neptune", neptuneProbes);

            foreach (var planet in planetProbes)
            {
                Console.WriteLine($"The planet {planet.Key} has been visited by these NASA probes: {string.Join(", ", planet.Value)}.");
            }

        }
    }
}
