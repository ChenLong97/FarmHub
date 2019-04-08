using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FarmHub
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute
            //(
            //    name: "Default",
            //    url: "Areas/Admin/{controller}/{action}/{id}",
            //    defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional, }
            //    //namespaces: new[] { "FarmHub.Areas.Admin.Controllers" }

            //);

            routes.MapRoute
           (
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Register", action = "Create", id = UrlParameter.Optional, }
           //namespaces: new[] { "FarmHub.Areas.Admin.Controllers" }

           );
        }
    }
}
