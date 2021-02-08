using StockVest.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Repository
{
    public interface ICustomer
    {
        Task CreateCustomerAync(Customer customer);
        IEnumerable<Customer> GetAll();
        Customer GetById(int customerId);
        Task UpdateCustomerAsync(int customerId);
        Task UpdateCustomerAsync(Customer customer);
        Task Delete(int customerId);


    }
}
