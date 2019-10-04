using System;
using System.Collections.Generic;

namespace ListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            words.Add("Hello");
            words.Add("Burger");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            //Console.WriteLine(words);

            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(72);
            numbers.Add(-1);

            numbers.ForEach(num => Console.WriteLine(num));

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);

            numbers[0] = 999;
            Console.WriteLine(numbers[0]);

            List<double> prices = new List<double>() {
                2.3, 5.99, -2.33
            };
            prices.Add(89.99);

            //Console.WriteLine(numbers);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Now we're playing with Dictionaries");
            Console.WriteLine();


            Dictionary<string, double> itemsAndPrices = new Dictionary<string, double>();
            itemsAndPrices.Add("Balvenie 15 Single Cask", 120.00);
            itemsAndPrices.Add("ham sadwich", 0.99);
            itemsAndPrices.Add("old can", 0);
            itemsAndPrices.Add("8", 8.00);

            foreach (KeyValuePair<string, double> kvp in itemsAndPrices)
            {
                Console.WriteLine($"The {kvp.Key} costs ${kvp.Value}");
            }

            Console.WriteLine(itemsAndPrices);

            List<Dictionary<string, string>> animals = new List<Dictionary<string, string>>() {
                new Dictionary<string, string>() {
                    {"Name", "Brantley"},
                    {"Hobby", "Fishing"}
                },
                new Dictionary<string, string>() {
                    {"Name", "Eric"},
                    {"Hobby", "Funny stuff"}
                },
                new Dictionary<string, string>() {
                    {"Name", "Bennett"},
                    {"Favorite Book", "Moby Dick"}
                }
            };

            foreach (Dictionary<string, string> animal in animals)
            {
                foreach (KeyValuePair<string, string> kvp in animal)
                {
                    Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
                }
            }

            Dictionary<string, string> bennett = animals[2];
            string FavoriteBook = bennett["Favorite Book"];
            Console.WriteLine(FavoriteBook);

            Console.WriteLine(animals[2]["Favorite Book"]);
        }
    }
}
