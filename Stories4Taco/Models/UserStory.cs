using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stories4Taco.Models
{
    public class UserStory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("UserStep")]
        public int UserStepId { get; set; }
        public virtual UserStep UserStep { get; set; }

        //[ForeignKey("Release")]
        public int ReleaseId { get; set; }
        //public virtual Release Release { get; set; }
    }
}