using Interface.Repositories.Abstract;
using System;

namespace Interface.Repositories.Concrate
{
    public class OracleCustomerRepository : ICustomerRepository
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }

        public void Filter()
        {
            Console.WriteLine("Oracle Filter");
        }
    }
}