using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AppBll.Infrastructure;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using WebApplication.Infrastructure;

namespace WebApplication
{
  public class MvcApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {
      AreaRegistration.RegisterAllAreas();
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);

      NinjectModule itemModule = new ItemModule();
      NinjectModule serviceModule = new ServiceModule();
      var kernel = new StandardKernel(itemModule, serviceModule);
      DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
    }
  }
}
