using System.Web.Mvc;
using System.Web.Routing;

namespace MobWeb.Site
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Clientes", action = "ListarClientes", id = UrlParameter.Optional }
            );
        }
    }
}
