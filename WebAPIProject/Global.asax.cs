using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using WebAPIProject.App_Start;

namespace WebAPIProject
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static void RegisterWebApiFilters(System.Web.Http.Filters.HttpFilterCollection filters)
        {
            filters.Add(new ActionFilter());
            filters.Add(new AuthorizeFilter());
        }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RegisterWebApiFilters(GlobalConfiguration.Configuration.Filters);
        }
    }
}
