using Stuck.Entity;
using Stuck.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository.Infrastructure
{
    public class CustomerService : ICustomerSevice
    {
        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task CreateCustomerAync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int customerId) => _context.Customers.Where(a => a.Id == customerId).FirstOrDefault();
       

        public Task UpdateCustomerAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
