using Interface.Repositories.Abstract;

namespace Interface.Business.Concrete
{
    public class CustomerManager
    {
        public void Add(ICustomerRepository customerDal)
        {
            customerDal.Add();
        }

        public void Delete(ICustomerRepository customerDal)
        {
            customerDal.Delete();
        }

        public void Update(ICustomerRepository customerDal)
        {
            customerDal.Update();
        }
    }
}