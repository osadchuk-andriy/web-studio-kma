using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using web_studio.model;
using System.Data.Entity;

namespace web_studio.dao
{
    public class BookEntityContext : DbContext
    {
        public BookEntityContext()
            : base("name=DbConnectionString")
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
