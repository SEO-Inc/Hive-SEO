using Hive.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hive.Controllers
{
    public class ServiceController : Controller
    {
        private IHiveRepository _repo;

        public ServiceController(IHiveRepository repo)
        {
            _repo = repo;
        }
        // GET: Service
        public ActionResult ActiveServices()
        {
            var services = _repo.GetServices();
            return View(services);
        }

    }
}