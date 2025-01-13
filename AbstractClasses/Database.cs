using System;

namespace AbstractClasses
{
    public abstract class Database
    {
        /* 
        İçi dolu olmayan Virtual metotdur.
        newlenemez.
        */
        public void Add() // Tamamlanmış Metotlar.
        {
            Console.WriteLine("Added by default!");
        }

        public abstract void Delete(); // Tamamlanmamış Metotlar.
    }
}