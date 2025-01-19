using System.Collections;
using System;

namespace Collection
{
    public class ArrayLists
    {
        public void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Samsun");
            cities.Add("İstanbul");
            cities.Add("Kocaeli");
            cities.Add("Ankara");
            cities.Add(1);
            cities.Add('B');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}