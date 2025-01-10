using Interface.Repositories.Abstract;
using System;

namespace Interface.Repositories.Concrate
{
    public class SqlServerCustomerRepository : ICustomerRepository
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }

        public void Filter()
        {
            Console.WriteLine("Sql Filter");
        }
    }
}