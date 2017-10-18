using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WeWap
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            string filepath = Server.MapPath("~/");
            AppSets.InitialAppSetting(this.GetType().BaseType.Namespace);
            Configer.InitialConfig(filepath, "WeCanConfig");
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
