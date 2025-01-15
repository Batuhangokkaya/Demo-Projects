using System;

namespace ConstructiveBlocks.Base_Constructor
{
    public class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {
        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
}