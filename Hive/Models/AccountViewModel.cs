using Hive.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hive.Models
{
    public class AccountViewModel
    {
        public AccountViewModel(Account account)
        {
            Account = account;
            AvailableContacts = new List<SelectListItem>();
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
        }

        public AccountViewModel()
        {
            Account = new Account();
            Contact = new Contact();
            AvailableContacts = new List<SelectListItem>();
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
        }

        public Account Account { get; set; }

        public Contact Contact { get; set; }

        public bool IsExistingContact { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }

        [Display(Name = "State")]
        public int StateId { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }

        [Display(Name = "Main Contact")]
        public int ContactId { get; set; }
        public IList<SelectListItem> AvailableContacts { get; set; }
        
        [Display(Name = "Company Url")]
        public string Url { get; set; }
    }
}