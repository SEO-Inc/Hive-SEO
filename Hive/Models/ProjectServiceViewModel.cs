using Hive.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hive.Models
{
    public class ProjectServiceViewModel
    {

        public ProjectServiceViewModel(int accountid)
        {
            ProjectService = new ProjectService();
            Account = accountid;
            AvailableProjects = new List<SelectListItem>();
            AvailableServices = new List<SelectListItem>();
        }


        public ProjectService ProjectService { get; set; }

        [Display(Name = "Project")]
        public int ProjectId { get; set; }

        [Display(Name = "Service")]
        public int ServiceId { get; set; }

        public IList<SelectListItem> AvailableProjects { get; set; }
        public IList<SelectListItem> AvailableServices { get; set; }

        public int Account { get; set; }
    }
}