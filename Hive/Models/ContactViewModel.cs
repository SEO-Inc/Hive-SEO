using Hive.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace Hive.Models
{
    public class ContactViewModel
    {
        public ContactViewModel(Contact contact)
        {
            Contact = contact;
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
        }

        public ContactViewModel()
        {
            Contact = new Contact();
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
        }

        public Contact Contact { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }
        [Display(Name = "State")]
        public int StateId { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }
        [Display(Name = "Website")]
        public string Url { get; set; }

    }
}