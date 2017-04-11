using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.model
{
    [Table("users_to_project")]
    public class UserToProject
    {
        [Key]
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual Project Project { get; set; }
    }
}