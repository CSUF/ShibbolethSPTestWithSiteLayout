// (c) California State University, Fullerton


using System.Web.Mvc;
using System.Web.Routing;


[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Csuf.ShibbolethSPTestWithSiteLayout.App_Start.RouteConfig), "Start")]


namespace Csuf.ShibbolethSPTestWithSiteLayout.App_Start
{
	public static class RouteConfig
	{

		public static void Start()
		{
			RegisterRoutes(RouteTable.Routes);
		}

		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.MapRoute(
					name: "Default",
					url: "{controller}/{action}/{id}",
					defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}

}
