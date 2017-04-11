using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.model
{
    [Table("projects")]
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ProjectStatus Status { get; set; }
        public virtual ICollection<UserToProject> Users { get; set; }
    }
}