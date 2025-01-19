using System.Collections.Generic;
using System;

namespace Collection
{
    public class TypeSafeCollections
    {
        public void TypeSafeCollection()
        {
            TypeSafeList typeSafeList = new TypeSafeList();
            typeSafeList.List();

            List<Customer> customers1 = new List<Customer>();
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Batuhan"
            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Yasemin"
            };
            customers1.Add(customer1);
            customers1.Add(customer2);

            foreach (var customer in customers1)
            {
                Console.WriteLine(customer.Id + " " + customer.Name);
            }
        }
    }
}