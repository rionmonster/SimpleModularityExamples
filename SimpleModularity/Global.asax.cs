using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleModularity
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }

    public static class Application
    {
        // Define a static Dictionary indicating the available areas
        public static Dictionary<string, bool> ModulesEnabled = new Dictionary<string, bool>();
    }
}
