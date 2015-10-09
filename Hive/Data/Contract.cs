using Hive.Data.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class Contract
    {
        public Contract()
        {
            this.Created = System.DateTime.Now;
        }

        public int Id { get; set; }

        [Display(Name = "Contract Name")]
        public String Name { get; set; }

        public int? AccountId { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        [Display(Name = "Contract Length")]
        public int Period { get; set; }

        public bool IsOptOut { get; set; }

        [Display(Name = "Opt out Length")]
        public int OptOutPeriod { get; set; }

        [Display(Name = "Monthly Budget")]
        public decimal? MonthlyBudget { get; set; }

        public decimal TotalValue { get; set; }
        [Display(Name = "Contract Type")]
        public ContractProjectType? ContractProjectType { get; set; }

        [Display(Name = "Billing Model")]
        public ContractBillingType? ContractBillingType { get; set; }

        [Display(Name = "Deal Type")]
        public ContractDealType? ContractDealType { get; set; }

        [Display(Name = "Deal Source")]
        public ContractSource? ContractSource { get; set; }

        [Display(Name = "Status")]
        public ContractStatus? ContractStatus { get; set; }

        public DateTime Created { get; set; }

        public virtual Account Account { get; set; }

        public ICollection<ProjectService> ProjectService { get; set; }

    }
}