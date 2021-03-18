using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository.Dto
{
    public class TransactionDto
    {

        public TransactionDto()
        {

        }

        public decimal Withdraw { get; set; }
        public decimal Deposit { get; set; }
        public decimal TransactionDate { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal InitialBalance { get; set; }


        public decimal Credit(decimal amount, decimal currentBalance)
        {

            CurrentBalance += amount;
            return CurrentBalance;
        }

        public decimal Debit(decimal amount, decimal currentBalance)
        {
            
            CurrentBalance -= amount;
            return CurrentBalance;
        }

        public string Nune(decimal amount, decimal currentBalance)
        {
            if (CurrentBalance <= 0 || CurrentBalance == 0)
            
            return "Insufficient balance";
            return "Insufficient balance";
            

            
        }
    }
}
