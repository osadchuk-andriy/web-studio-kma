using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

using web_studio.dao;
using web.model;
using web_studio.model;
using web_studio.web.Models;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<UsersEntityContext>());
            
            return View();
        }

        //
        // GET: /Studio/
        public ActionResult Studio()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}