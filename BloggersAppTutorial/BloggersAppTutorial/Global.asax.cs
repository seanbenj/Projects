using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using HangingTree.Models;

namespace BloggersAppTutorial
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public BlogArticleRepository mainBlog;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            mainBlog = new BlogArticleRepository(@"C:\Users\Student\Documents\GitHub\Projects\BloggersAppTutorial\BloggersAppTutorial\blogFiles", "blog.dat");
        }
    }
}
