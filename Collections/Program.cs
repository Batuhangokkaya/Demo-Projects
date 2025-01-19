using System.Collections.Generic;
using System.Collections;
using System;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList

            // Tip Güvenli Koleksiyonlarla Çalışmak.
            // Sadece Belirtilen Veri Türünde Değer Atanır.
            List<string> cities2 = new List<string>();
            cities2.Add("Adana");
            cities2.Add("Bursa");
            Console.WriteLine(cities2.Contains("Adana"));
            foreach (var city2 in cities2)
            {
                Console.WriteLine(city2);
            }

            List<Customer> customers1 = new List<Customer>();
            customers1.Add(new Customer { Id = 1, Name = "Batuhan" });
            customers1.Add(new Customer { Id = 2, Name = "Yasemin" });
            foreach (var customer1 in customers1)
            {
                Console.WriteLine(customer1.Id + " " + customer1.Name);
            }

            List<Customer> customers2 = new List<Customer>
            {
                new Customer { Id = 1, Name = "Batuhan" },
                new Customer { Id = 2, Name = "Yasemin" }
            };
            foreach (var customer2 in customers2)
            {
                Console.WriteLine(customer2.Id + " " + customer2.Name);
            }

            // Collection Özellik ve Metodlarıyla Çalışmak
            List<Customer> customers3 = new List<Customer>
            {
                new Customer { Id = 1, Name = "Asuman" },
                new Customer { Id = 2, Name = "Yasemin" }
            };
            var customer = new Customer
            {
                Id = 3,
                Name = "Batuhan"
            };
            customers3.Add(customer);
            customers3.AddRange(new Customer[2] { new Customer { Id = 4, Name = "Burak" }, new Customer { Id = 5, Name = "Cüneyt" } }); // Dizi Halinde Ekler.

            customers3.Clear(); // Listeyi Temizler.
            Console.WriteLine(customers3.Contains(customer)); // İlgili Eleman Varmı Diye Kontrol Eder.
            var index1 = customers3.IndexOf(customer); // İlgili Değeri Kaçıncı Indexte Başladığını Gösterir.
            var index2 = customers3.LastIndexOf(customer); // İlgili Değeri Sondan Kaçıncı Indexte Başladığını Gösterir.
            customers3.Insert(0, new Customer { Id = 6, Name = "Türkan" }); // İstenilen Indexe Ekleme Yapar.
            customers3.Remove(customer); // Değişkene Atanan Değeri Siler Fazladan Silerken Sayıyı Açarsa Hata Vermez.
            customers3.RemoveAll(c => c.Name == "Burak"); // Belirtilen Değeri Siler.
            var count = customers3.Count; // Kaç Tane Eleman Olduğunu Gösterir.

            Console.WriteLine(count);
            Console.WriteLine(index1);
            Console.WriteLine(index2);

            // Dictionary İle Çalışmak
            // Anahtar İle Değer Aramak İçin Kullanılır.
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("KafKef", "Sagopa Kajmer");
            dictionary.Add("Pesimist", "Sagopa Kajmer");
            dictionary.Add("Computer", "Bilgisayar");

            Console.WriteLine(dictionary["KafKef"]);
            Console.WriteLine(dictionary.ContainsKey("Pesimist"));
            Console.WriteLine(dictionary.ContainsValue("Sagopa Kajmer"));
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.ReadKey();
        }

        class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}