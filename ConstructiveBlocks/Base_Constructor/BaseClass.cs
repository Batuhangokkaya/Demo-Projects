using System;

namespace ConstructiveBlocks.Base_Constructor
{
    public class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine($"{_entity} message.");
        }
    }
}