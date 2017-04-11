using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.model
{
    [Table("users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Nick { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public Roles Role { get; set; }
        public virtual ICollection<UserToProject> Projects { get; set; }
    }
}
