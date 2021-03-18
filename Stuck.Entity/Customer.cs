using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Entity
{
    public class Customer
    {
        //public Customer()
        //{
        //    BrokerageAccounts = new List<BrokerageAccount>();
        //}
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string CustomerCode { get; set; }

       // public IEnumerable<BrokerageAccount> BrokerageAccounts { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
        public IEnumerable<Stock> Stocks { get; set; }
    }
}
