using System;

namespace Heredity
{
    public class VirtualMethods
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default!");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default!");
        }

    }

    public class SqlServer : VirtualMethods
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Server!");
            //base.Add();
        }

        public override void Delete()
        {
            base.Delete();
        }
    }

    public class OracleServer : VirtualMethods
    {
        public override void Add()
        {
            Console.WriteLine("Added by Oracle Server!");
            //base.Add();
        }

        public override void Delete()
        {
            base.Delete();
        }
    }
}