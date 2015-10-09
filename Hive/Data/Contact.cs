using Hive.Data.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class Contact
    {
        public Contact()
        {
            this.Created = System.DateTime.Now;
        }

        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int? AccountId { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set;}
        public string City { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        [Display(Name = "Zip Code")]
        public string PostalCode { get; set; }
        public int? DomainId { get; set; }
        public string Phone { get; set; }
        public string PhoneExt { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        [Display(Name = "Contact Type")]
        public ContactType? ContactType { get; set; }
        public DateTime Created { get; set; }
        [Display(Name = "Url")]
        public virtual Domain Domain { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        [Display(Name = "Company")]
        public virtual Account Account { get; set; }

        [Display(Name = "Name")]
        public string FullName
        {
            get
            {
                string dspFirst =
                    string.IsNullOrWhiteSpace(this.FirstName) ? "" : this.FirstName;
                string dspLast =
                    string.IsNullOrWhiteSpace(this.LastName) ? "" : this.LastName;

                return dspFirst + " " + dspLast;
            }
        }

        // Concatenate the address info for display in tables and such:
        //public string DisplayAddress
        //{
        //    get
        //    {
        //        string dspAddress =
        //            string.IsNullOrWhiteSpace(this.Address) ? "" : this.Address;
        //        string dspCity =
        //            string.IsNullOrWhiteSpace(this.City) ? "" : this.City;
        //        string dspState =
        //            string.IsNullOrWhiteSpace(this.State.Name) ? "" : this.State.Name;
        //        string dspPostalCode =
        //            string.IsNullOrWhiteSpace(this.PostalCode) ? "" : this.PostalCode;

        //        return string
        //            .Format("{0} {1} {2} {3}", dspAddress, dspCity, dspState, dspPostalCode);
        //    }
        //}
    }
}