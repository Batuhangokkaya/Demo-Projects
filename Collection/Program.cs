using System;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            Console.WriteLine("--Array List--");
            ArrayLists arrayList = new ArrayLists();
            arrayList.ArrayList();

            // Type Safe Collections
            Console.WriteLine("\n--Type Safe Collections--");
            TypeSafeCollections typeSafeCollections = new TypeSafeCollections();
            typeSafeCollections.TypeSafeCollection();

            // Collection Methods
            Console.WriteLine("\n--Collection Methods--");
            CollectionMethods collectionMethods = new CollectionMethods();
            collectionMethods.CollectionMethod();

            // Dictionary
            Console.WriteLine("\n--Dictionary--");
            Dictionarys dictionarys = new Dictionarys();
            dictionarys.DictionaryList();

            Console.ReadKey();
        }
    }
}