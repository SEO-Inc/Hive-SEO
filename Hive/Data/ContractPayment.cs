using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class ContractPayment
    {
        public int Id { get; set; }

        public int ContractId { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }


    }
}