using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class ProjectService
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public int ContractId { get; set; }

        public int ServiceId { get; set; }

        public int QuantitySold { get; set; }

        public decimal TotalPrice { get; set; }

        public string Note { get; set; }

        public virtual Project Project { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual Service Service { get; set; }

    }
}