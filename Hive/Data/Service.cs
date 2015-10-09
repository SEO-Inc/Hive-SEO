using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DescriptionLong { get; set; }
        public bool IsActive { get; set; }
        public bool IsNewContractReq { get; set; }
        //For time tracking
        public bool IsMultiProject { get; set; }
        public bool IsBilledHourly { get; set; }
        public int Order { get; set; }
        public int ServiceCategoryId { get; set; }
        //for tasking
        public int DefaultTaskTypeId { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public string PriceNote { get; set; }
        public DateTime Created { get; set; }

        public virtual ServiceCategory ServiceCategory { get; set; }

    }
}