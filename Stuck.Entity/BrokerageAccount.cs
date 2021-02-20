
using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Entity
{
    /*The brokerage account is to help track actual data about a given acccount  of a customers*/
    public class BrokerageAccount
    {

        public BrokerageAccount()
        {
            Positions = new List<Position>();
            Orders = new List<Order>();


        }
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountTitle { get; set; }
        public decimal Total { get; set; }
        public decimal MarginBalance { get; set; }
        public bool IsRetirement { get; set; }
        public int CustomerID { get; set; }
        public decimal CashTotal { get; set; }
        public decimal PositionsTotal { get; set; }
        public int WatchListId { get; set; }
        //navigation



        public IEnumerable<Position> Positions { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public WatchList WatchList { get; set; }
    }
}
