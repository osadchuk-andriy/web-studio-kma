using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

using web.model;
using web_studio.dao;
using web_studio.model;
using web_studio.web.Models;

namespace web.Controllers.admin
{
    public class AdminProjectStuffController : Controller
    {
        private UsersEntityContext usersContext;

        public AdminProjectStuffController() : this(new UsersEntityContext()) { }

        public AdminProjectStuffController(UsersEntityContext usersContext)
        {
            this.usersContext = usersContext;
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<UsersEntityContext>());
        }

        // GET: AdminProjectStuff
        public ActionResult Index()
        {
            return View(usersContext.Users.ToList().Where(u => u.Role == Roles.stuff).ToList<User>());
        }
    }
}