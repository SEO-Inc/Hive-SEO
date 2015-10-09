using Hive.Data;
using Hive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hive.Controllers
{
    public class ContractController : Controller
    {
        private IHiveRepository _repo;

        public ContractController(IHiveRepository repo)
        {
            _repo = repo;
        }

        // GET: Contract
        public ActionResult Index()
        {
            var contracts = _repo.GetContracts().OrderByDescending(t => t.Created).ToList();
            return View(contracts);
        }

        public ActionResult Create()
        {
            ContractViewModel model = new ContractViewModel();
            model.AvailableAccounts.Add(new SelectListItem { Text = "-Please select-", Value = "Selects items" });
            var accounts = _repo.GetAccounts();
            foreach (var account in accounts)
            {
                model.AvailableAccounts.Add(new SelectListItem()
                {
                    Text = account.CompanyName,
                    Value = account.Id.ToString()
                });
            }
            return View(model);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GetProjectsByAccountId(string accountId)
        {
            if (String.IsNullOrEmpty(accountId))
            {
                throw new ArgumentNullException("accountId");
            }
            int id = 0;
            bool isValid = Int32.TryParse(accountId, out id);
            var projects = _repo.GetProjectsByAccountId(id);
            var result = (from p in projects
                          select new
                          {
                              id = p.Id,
                              name = p.Name
                          }).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}