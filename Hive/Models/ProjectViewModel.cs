using Hive.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace Hive.Models
{
    public class ProjectViewModel
    {
        public ProjectViewModel(Project project)
        {
            Project = project;
            AvailableAccounts = new List<SelectListItem>();
        }

        public ProjectViewModel()
        {
            Project = new Project();
            AvailableAccounts = new List<SelectListItem>();
     
        }

        public Project Project { get; set; }

        [Display(Name = "Account")]
        public int AccountId { get; set; }
        public IList<SelectListItem> AvailableAccounts { get; set; }


        [Display(Name = "Project URL")]
        public string Url { get; set; }

    }
}