// (c) California State University, Fullerton.  All rights reserved.

using System.Web.Mvc;

namespace Csuf.ShibbolethSPTestWithSiteLayout.Controllers
{
	public class BrowserController : Controller
	{

		[AllowAnonymous]
		public ActionResult Incompatible()
		{
			return View();
		}

	}
}