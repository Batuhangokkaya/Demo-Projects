using Interface.Repositories.Abstract;
using System;

namespace Interface.Repositories.Concrate
{
    public class StudentRepository : IPencilRepository, INotebookRepository
    {
        public void Notebook()
        {
            Console.WriteLine("Student's pen");
        }

        public void Pencil()
        {
            Console.WriteLine("Student's notebook");
        }
    }
}