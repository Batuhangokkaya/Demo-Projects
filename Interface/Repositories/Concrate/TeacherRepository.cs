using Interface.Repositories.Abstract;
using System;

namespace Interface.Repositories.Concrate
{
    public class TeacherRepository : IPollingRepository, IPencilRepository
    {
        public void Pencil()
        {
            Console.WriteLine("Teacher's Pen.");
        }

        public void Polling()
        {
            Console.WriteLine("Teacher's attendance.");
        }
    }
}