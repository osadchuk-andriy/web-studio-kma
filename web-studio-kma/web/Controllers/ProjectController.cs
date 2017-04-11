using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using web.model;
using web_studio.dao;
using web_studio.model;
using web_studio.web.Models;

namespace web.Controllers
{
    public class ProjectController : Controller
    {
        UsersEntityContext usersContext;

        public ProjectController() //: this()
        {
            //101this(new UsersEntityContext());
        }

        public ProjectController(UsersEntityContext usersContext)
        {
            this.usersContext = usersContext;
        }

        // GET: Project
        public ActionResult Index()
        {
            return View();
        }
    }
}