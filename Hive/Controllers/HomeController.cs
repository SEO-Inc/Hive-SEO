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
    [Authorize]
    public class HomeController : Controller
    {
        private IHiveRepository _repo;

        public HomeController(IHiveRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Accounts()
        {
            var accounts = _repo.GetAccounts().OrderByDescending(t => t.Created).Take(25).ToList();
            return View(accounts);
        }

        public ActionResult CreateAccount()
        {
            AccountViewModel model = new AccountViewModel();
            model.AvailableContacts.Add(new SelectListItem { Text = "-Please select-", Value = "Selects items" });
            var contacts = _repo.GetContacts();
            foreach (var contact in contacts)
            {
                model.AvailableContacts.Add(new SelectListItem()
                {
                    Text = contact.FullName,
                    Value = contact.Id.ToString()
                });
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAccount(AccountViewModel accountview)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var account = accountview.Account;
                    account.DomainId = _repo.AddDomain(accountview.Url);

                    if (accountview.IsExistingContact)
                    {
                        
                    }
                    else
                    {
                        var contact = new Contact();
                        contact.DomainId = _repo.AddDomain(accountview.Url);
                        contact.CountryId = accountview.CountryId;
                        contact.StateId = accountview.StateId;
                        _repo.AddContact(contact);
                    }
                    
                    

                    return RedirectToAction("AllAccounts");
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(accountview);
        }
        
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}