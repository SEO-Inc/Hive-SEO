using Hive.Data.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class Project
    {
        public Project()
        {
            this.Created = System.DateTime.Now;
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int AccountId { get; set; }
        public int DomainId { get; set; }
        public int ProjectStatusId { get; set; }
        [Display(Name = "Project Type")]
        public ContractProjectType? ContractProjectType { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        public DateTime Created { get; set; }
        [Display(Name = "Project Url")]
        public virtual Domain Domain { get; set; }
        [Display(Name = "Project Status")]
        public virtual ProjectStatus ProjectStatus { get; set; }

        public virtual Account Account { get; set; }

        public ICollection<Contract> Contracts { get; set; }

        public ICollection<Service> Services { get; set; }

    }
}