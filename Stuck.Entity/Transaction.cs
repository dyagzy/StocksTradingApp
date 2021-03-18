using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Entity
{
    public class Transaction
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal (18,2)")]
        public decimal Withdrawal { get; set; }

        [Column(TypeName = "decimal (18,2)")]
        public decimal AmountDeposit { get; set; }
        public DateTime TransactionDate { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal CurrentBalance { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal InitialBalance { get; set; }
        public string StockSymbol { get; set; }
        public int NumbrOfShare { get; set; }

        //navigation
        
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }


        /*

        You can create a MOC data to respresnet the NSE Api
LIST OF TABLES (4 TABLES)

USER TABLE ====> to contain customer information/track login

BALANCE TABLE ===> to track customer current balance 

TRANSCATION TBALE ===> to track withdrawl and deposits

ORDERS TABLE ====> for buying and selling of stocks


ENUMS

OrderType

Sell
Buy




        */


        //Navigation property
    }
}
