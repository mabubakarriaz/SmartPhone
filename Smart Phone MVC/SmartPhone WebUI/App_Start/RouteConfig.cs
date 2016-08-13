using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Com.SmartPhone.App.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute("Login",
            "User/Cars/ForSale/{id}",
            new { controller = "User", action = "Login", id = UrlParameter.Optional });

            routes.MapRoute("ForgorPassword",
            "User/search",
            new { controller = "User", action = "ForgotPassword" });

            routes.MapRoute("Register",
            "User/Register/ForSale/{id}",
            new { controller = "User", action = "Register", id = UrlParameter.Optional });

        }
    }
}
