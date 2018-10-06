// (c) California State University, Fullerton. All rights reserved.


using System.Web.Mvc;

namespace Csuf.ShibbolethSPTestWithSiteLayout.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			if (!string.IsNullOrWhiteSpace(Request.ServerVariables["HTTP_EPPN"])) { return View(); }
			else { return Redirect("~/"); }
		}

		[HttpPost]
		public ActionResult SignOut()
		{
			return View();
		}


	}

}