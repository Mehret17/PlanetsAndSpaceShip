using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceShips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            var lastTwoPlanets = new List<string>();
            lastTwoPlanets.Add("Neptune"); 
            lastTwoPlanets.Add("Uranius");

            planetList.AddRange(lastTwoPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            var rockyMountains = planetList.GetRange(3, 4);

            foreach(string rockyPlanet in rockyMountains )
            {
                Console.WriteLine(rockyPlanet);
            }
            Console.WriteLine();

            planetList.Remove("Pluto");

            foreach(string planet in planetList)
            {
                Console.WriteLine(planet);
            }

           // Console.WriteLine(planetList);
            Console.ReadLine();

        }
    }
}
