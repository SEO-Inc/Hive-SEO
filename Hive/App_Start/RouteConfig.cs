using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hive
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "accounts",
                url: "accounts",
                defaults: new { controller = "Home", action = "Accounts" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute("GetStatesByCountryId",
                            "contact/getstatesbycountryid/",
                            new { controller = "Contact", action = "GetStatesByCountryId" },
                            new[] { "Hive.Controllers" });

            routes.MapRoute("GetProjectsByAccountId",
                            "project/getprojectsbyaccountid/",
                            new { controller = "Project", action = "GetProjectsByAccountId" },
                            new[] { "Hive.Controllers" });
        }
    }
}
