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
    public class ProjectController : Controller
    {
        
        private IHiveRepository _repo;

        public ProjectController(IHiveRepository repo)
        {
            _repo = repo;
        }

        // GET: Project
        public ActionResult Index()
        {
            var projects = _repo.GetProjects().OrderByDescending(t => t.Created).ToList();
            return View(projects);
        }

        // GET: Project/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            ProjectViewModel model = new ProjectViewModel();
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

        // POST: Project/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjectViewModel projectview)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var project = projectview.Project;
                    project.DomainId = _repo.AddDomain(projectview.Url);
                    project.AccountId = projectview.AccountId;
                    project.ProjectStatusId = (int)projectview.Project.ContractProjectType.Value;
                    _repo.AddProject(project);
                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(projectview);
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Project/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Project/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
            var projeects = _repo.GetProjectsByAccountId(id);
            var result = (from s in projeects
                          select new
                          {
                              id = s.Id,
                              name = s.Name
                          }).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
