using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Lists_LandonBarnett
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of the games.
            List<string> games = new List<string>
            {
                "CS:GO",
                "Halo 3",
                "Apex Legends",
                "Fifa 22",
                "Minecraft"
            };
            // 2nd list of games.
            string[] otherGames = new string[]
            {
                "Rocket League",
                "Farcry 3"
            };
            // prints the list of games
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            // this counts the amount of games on the list.
            Console.WriteLine($"\nGames in list: {games.Count}");

            //prints the numbers to the line.
            games.AddRange(otherGames);

            // this counts the 2 line of games.
            Console.WriteLine($"\ngames in list:{games.Count}");

            // prints Halo to the line of games.
            if (games.Contains("Halo"))
            {
                Console.WriteLine("\nMASTER CHEIF IS IN IN THE HOUSE!!");
            }
            else //if halo isn't found then it is added
            {
                games.Add("Halo");
            }

            int myInt = 6;
            // if more than 6, removes farcry
            if (myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else //otherwise states game not found
            {
                Console.WriteLine("\nGame not found!");
            }

            // shows all games to the the list.
            Console.WriteLine("ALL games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            // sorts the games in or oder.
            games.Sort();

            // games sorted in alphabetical order and printed
            Console.WriteLine("\nSorted games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            string[] newList = new string[games.Count];

            //copies the games list to the newList
            games.CopyTo(newList);

            // clears the elements in the games list
            games.Clear();

            // new list of games.
            Console.WriteLine("New List:");
            foreach (string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}