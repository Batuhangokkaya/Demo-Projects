using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My Name Is Batuhan Gökkaya";

            // .Length : İçeriğin uzunluğunu Gösterir.
            var result1 = sentence.Length;
            Console.WriteLine($".Length : {result1}");

            // .Clone() : Sonradan değeri değiştirsek bile .Clone() metodunu kullandığımız için sonuçu çağırdığımızda klonlanmış değeri yazacaktır.
            var result2 = sentence.Clone();
            sentence = "My Name Is Yasemin Gökkaya";
            Console.WriteLine($".Clone() : {result2}");

            // .EndsWith() : Değer ilgili harfle bittiğini kontrol etmek için kullanılır.
            bool result3 = sentence.EndsWith("a");
            Console.WriteLine($".EndsWith() : {result3}");

            // .StartsWith() : Değer ilgili harfle başladığını kontrol etmek için kullanılır.
            bool result4 = sentence.StartsWith("My");
            Console.WriteLine($".StartsWith() : {result4}");

            // .IndexOf() : Aranan kelimeyi kaçıncı indexten başladığını gösterir. (Aranan değeri ilk değerle karşılaştığında gösterir ve bulamazsa -1 değerini döndürür.)
            var result5 = sentence.IndexOf("Name");
            Console.WriteLine($".IndexOf() : {result5}");

            // LastIndexOf() : Aranan kelimeyi sondan kaçıncı indexten başladığını gösterir. (aranan değeri son değerle karşılaştığında gösterir ve bulamazsa -1 değerini döndürür.)
            var result6 = sentence.LastIndexOf(" ");
            Console.WriteLine($".LastIndexOf() : {result6}");

            // Insert() : String ifadeye başka bir string ifadeyi eklemek için kullanılır.
            var result7 = sentence.Insert(0, "Hello ");
            Console.WriteLine($".Insert() : {result7}");

            // Substring : String değeri parçalamak için kullanılır. (1.Parametre : Kaçtan başlayacğını belirtir. 2.Parametre : Kaça kadar alacağını belirtir.)
            var result8 = sentence.Substring(3);
            var result9 = sentence.Substring(3, 4);
            Console.WriteLine($".Substring() : {result8}");
            Console.WriteLine($".Substring(3, 4) : {result9}");

            // ToLower : Büyük harflerle yazılmış değeri küçük harflere çevirmek için kullanılır.
            var result10 = sentence.ToLower();
            Console.WriteLine($".ToLower() : {result10}");

            // ToUpper : Küçük harflerle yazılmış değeri büyük harflere çevirmek için kullanılır.
            var result11 = sentence.ToUpper();
            Console.WriteLine($".ToUpper() : {result11}");

            // Replace : String değerlerin içindeki istenilen değeri değiştirmek için kullanılır.
            var result12 = sentence.Replace(" ", "-");
            Console.WriteLine($".Replace() : {result12}");

            // Remove : String değerlerinden belli bir indexten sonrasını silmek için kullanılır. (1.Parametre : Kaçtan başlayacğını belirtir. 2.Parametre : Kaça kadar alacağını belirtir.)
            var result13 = sentence.Remove(2);
            var result14 = sentence.Remove(2, 5);
            Console.WriteLine($".Remove() : {result13}");
            Console.WriteLine($".Remove() : {result14}");

            Console.ReadLine();
        }
    }
}