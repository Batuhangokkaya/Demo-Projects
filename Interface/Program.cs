using Interface.Business.Concrete;
using Interface.Repositories.Abstract;
using Interface.Repositories.Concrate;
using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ICustomerDal
            // 1. Kullanım
            CustomerManager customerManager                         = new CustomerManager();
            SqlServerCustomerRepository sqlServerCustomerRepository = new SqlServerCustomerRepository();
            OracleCustomerRepository oracleCustomerRepository       = new OracleCustomerRepository();

            customerManager.Add(oracleCustomerRepository);

            Console.WriteLine();

            // 2. Kullanım
            ICustomerRepository[] customerDals = { new SqlServerCustomerRepository(), new OracleCustomerRepository() };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Update();
                customerDal.Delete();
            }

            Console.WriteLine();

            // ISchoolDal
            INotebookRepository[] notebookRepositories = { new StudentRepository() };
            foreach (var notebookRepositorie in notebookRepositories)
            {
                notebookRepositorie.Notebook();
            }

            IPencilRepository[] pencilRepositories = { new StudentRepository(), new TeacherRepository() };
            foreach (var pencilRepositorie in pencilRepositories)
            {
                pencilRepositorie.Pencil();
            }

            IPollingRepository[] pollingRepositories = { new TeacherRepository() };
            foreach(var pollingRepositorie in pollingRepositories)
            {
                pollingRepositorie.Polling();
            }

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}