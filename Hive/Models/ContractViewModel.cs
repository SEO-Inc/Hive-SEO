using Hive.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hive.Models
{
    public class ContractViewModel
    {
        public ContractViewModel(Contract contract)
        {
            Contract = contract;
            AvailableAccounts = new List<SelectListItem>();
            //AvailableProjects = new List<SelectListItem>();
            //this.ProjectServices = new List<ProjectService>() { new ProjectServiceViewModel(1) };
        }

        public ContractViewModel()
        {
            Contract = new Contract();
            AvailableAccounts = new List<SelectListItem>();
            //AvailableProjects = new List<SelectListItem>();
            //this.ProjectServices = new List<ProjectService>() { new ProjectServiceViewModel(this.AccountId) };
     
        }

        public Contract Contract { get; set; }

        [Display(Name = "Account")]
        public int AccountId { get; set; }

        //[Display(Name = "Project")]
        //public int ProjectId { get; set; }
        public IList<SelectListItem> AvailableAccounts { get; set; }

        //public List<ProjectService> ProjectServices { get; set; }


    }
}