using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.Controllers
{
    public class UserPageController : Controller
    {
        //
        // GET: /UserPage/
        public ActionResult UserPage()
        {
            ViewBag.Message = "Your personal page.";

            return View();
        }
	}
}