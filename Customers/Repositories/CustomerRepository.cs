using System.Collections.Generic;
using System.Threading;
using Customers.DTO;
using Customers.Services;

namespace Customers.Repositories
{
    public class CustomerRepository
    {
        public Customer GetById(int id)
        {
            Thread.Sleep(5000);
            return new Customer {Id = id, Name = "Mark Pearl"};
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Customer Save(Customer customer)
        {
            return new Customer {Id = 1, Name = "Mark Pearl"};
        }

        public void Delete(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}