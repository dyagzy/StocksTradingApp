using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Entity
{
    public class Balance
    {

        public int Id { get; set; }
        public static decimal InitialBalance { get; set; } 
        public static decimal AmountDeposit { get; set; }
        public decimal CurrentBalance { get; set; } 

        //navigation
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public decimal UpdateCurrentBalance()
        {
           return CurrentBalance = InitialBalance + AmountDeposit;
        }

        public bool CanPurchase(decimal purchaseAmount)
        {
            return purchaseAmount < CurrentBalance;
        }
    }
}
