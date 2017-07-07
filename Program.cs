using System;
using System.Collections.Generic;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
           Console.WriteLine(planetList);
            List<string> lastPlanets= new List<string>{
                "Neptune", "Uranus"
            };

            planetList.AddRange(lastPlanets);

            planetList.Insert(1,"Venus");
            planetList.Insert(2,"Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanets= new List<string>{};
            rockyPlanets= planetList.GetRange(0,4);
            planetList.Remove("Pluto");

            foreach(string x in rockyPlanets){
                Console.WriteLine(x);

            Dictionary<string, string> probe= new Dictionary<string, string>();
                probe.Add("Mercury", "Mariner 10");
                probe.Add("Venus", "Mariener 2");
                probe.Add("Earth", "Surveyor 7");
                probe.Add("Mars", "Maven");
                probe.Add("Jupiter", "Pioneer 10");
            }
        }
    }
}
