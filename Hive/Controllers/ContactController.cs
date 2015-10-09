using Hive.Data;
using Hive.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hive.Controllers
{
    public class ContactController : Controller
    {

        private IHiveRepository _repo;

        public ContactController(IHiveRepository repo)
        {
            _repo = repo;
        }
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllContacts()
        {
            var contacts = _repo.GetContacts().OrderByDescending(t => t.Created).Take(25).ToList();
            return View(contacts);
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            ContactViewModel model = new ContactViewModel();
            model.AvailableCountries.Add(new SelectListItem { Text = "-Please select-", Value = "Selects items" });
            var countries = _repo.GetCountries();
            foreach (var country in countries)
            {
                model.AvailableCountries.Add(new SelectListItem()
                {
                    Text = country.Name,
                    Value = country.Id.ToString()
                });
            }
            return View(model);
        }

        // POST: Contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactViewModel contactview)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var contact = contactview.Contact;
                    contact.DomainId = _repo.AddDomain(contactview.Url);
                    contact.CountryId = contactview.CountryId;
                    contact.StateId = contactview.StateId;
                    _repo.AddContact(contact);
                    return RedirectToAction("AllContacts");
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(contactview);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GetStatesByCountryId(string countryId)
        {
            if (String.IsNullOrEmpty(countryId))
            {
                throw new ArgumentNullException("countryId");
            }
            int id = 0;
            bool isValid = Int32.TryParse(countryId, out id);
            var states = _repo.GetStatesByCountryId(id);
            var result = (from s in states
                          select new
                          {
                              id = s.Id,
                              name = s.Name
                          }).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }
       
    }
}