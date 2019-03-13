using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stories4Taco.Models
{
    public class UserStep
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //[ForeignKey("Goal")]
        public int GoalId { get; set; }
        //public virtual Goal Goal { get; set; }

        //[ForeignKey("UserStepId")]
        //public virtual ICollection<UserStory> UserStories { get; set; }
    }
}