
using Stuck.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository.Service
{
    public interface ICustomerSevice
    {
        Task CreateCustomerAync(Customer customer);
        IEnumerable<Customer> GetAll();
        Customer GetById(int customerId);
        Task UpdateCustomerAsync(int customerId);
        Task UpdateCustomerAsync(Customer customer);
        Task Delete(int customerId);


    }
}
