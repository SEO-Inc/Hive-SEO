using Hive.Data.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class Account
    {
        public Account()
        {
            Contacts = new HashSet<Contact>();
            this.ParentId = 1;
            this.AccountType = Hive.Data.enums.AccountType.Prospect;
            this.Created = System.DateTime.Now;
        }
        public int Id { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        [MaxLength(100)]
        public string CompanyName { get; set; }
        public int DomainId { get; set; }
        [Display(Name = "Account Type")]
        public AccountType? AccountType { get; set; }
        public int? ParentId { get; set; }
        public DateTime Created { get; set; }
        [Display(Name = "Company Url")]
        public virtual Domain Domain { get; set; }
        public ICollection<Contact> Contacts { get; set; }

        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}