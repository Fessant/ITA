using System.Web.Mvc;
using System.Web.Routing;
using RegistrationExample.App_Start;

namespace RegistrationExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMapperConfig.Configure();
        }
    }
}