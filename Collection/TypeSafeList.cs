using System.Collections.Generic;
using System;

namespace Collection
{
    public class TypeSafeList
    {
        public void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Adana");
            cities.Add("Bursa");
            Console.WriteLine(cities.Contains("Adana"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}