using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.WebApi;
using Autofac.Integration.Mvc;
using System.Reflection;

namespace RedBox.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //依赖注册
            var builder = new ContainerBuilder();

            var config =  GlobalConfiguration.Configuration;
           
            var assembly = Assembly.GetExecutingAssembly();
            var irepository = Assembly.Load("RedBox.IDAL");
            var repository = Assembly.Load("RedBox.DLL");
            builder.RegisterAssemblyTypes(irepository, repository)
              .AsImplementedInterfaces();

            var iservice = Assembly.Load("RedBox.IBLL");
            var service = Assembly.Load("RedBox.BLL");
            builder.RegisterAssemblyTypes(iservice, service)
              .AsImplementedInterfaces();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired ();//注册Controller

            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();//注册WebApi Controller
            //容器
            var container = builder.Build();
            //注入改为Autofac注入
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); //注册MVC容器
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
