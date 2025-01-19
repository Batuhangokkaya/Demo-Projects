using System.Collections.Generic;
using System;

namespace Collection
{
    public class CollectionMethods
    {
        public void CollectionMethod()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Asuman" },
                new Customer { Id = 2, Name = "Yasemin" }
            };
            var customer = new Customer
            {
                Id = 3,
                Name = "Batuhan"
            };
            customers.Add(customer);
            customers.AddRange(new Customer[2] { new Customer { Id = 4, Name = "Burak" }, new Customer { Id = 5, Name = "Cüneyt" } });

            customers.Clear(); // Listeyi temizler.
            Console.WriteLine(customers.Contains(customer)); // İlgili eleman var mı diye kontrol eder.
            var index1 = customers.IndexOf(customer); // İlgili değeri kaçıncı indexte başladığını gösterir.
            var index2 = customers.LastIndexOf(customer); // İlgili değeri sondan kaçıncı indexte başladığını gösterir.
            customers.Insert(0, new Customer { Id = 6, Name = "Türkan" }); // İstenilen indexe ekleme yapar.
            customers.Remove(customer); // Değişkene atanan değeri siler fazladan silerken sayıyı açarsa hata vermez.
            customers.RemoveAll(c => c.Name == "Burak"); // Belirtilen değeri siler.
            var count = customers.Count; // Kaç tane eleman olduğunu gösterir.

            Console.WriteLine(count);
            Console.WriteLine(index1);
            Console.WriteLine(index2);
        }
    }
}