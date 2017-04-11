using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using web.model;

namespace web_studio.dao
{
    public class UsersEntityContext : DbContext
    {
        public UsersEntityContext() : base("name=DbConnectionString") 
        { }

        public DbSet<User> Users { get; set; }
    }
}