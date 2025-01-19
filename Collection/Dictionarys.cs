using System.Collections.Generic;
using System;

namespace Collection
{
    public class Dictionarys
    {
        public void DictionaryList()
        {
            Dictionary<string, string> dictionaries = new Dictionary<string, string>();
            dictionaries.Add("Book", "Defter");
            dictionaries.Add("Keyboard", "Klavye");
            dictionaries.Add("Computer", "Bilgisayar");

            Console.WriteLine(dictionaries["Book"]); // İlgili indexin değerini verir
            Console.WriteLine(dictionaries.ContainsKey("Keyboard")); // İlgili anahtar var mı diye kontrol eder.
            Console.WriteLine(dictionaries.ContainsValue("Bilgisayar") + "\n"); // İlgili değer var mı diye kontrol eder.

            foreach (var dictionary in dictionaries)
            {
                Console.WriteLine($"Dictionary : {dictionary}");
                Console.WriteLine($"Dictionary Key : {dictionary.Key}");
                Console.WriteLine($"Dictionary Value : {dictionary.Value}\n");
            }
        }
    }
}