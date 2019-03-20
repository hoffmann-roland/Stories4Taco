using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stories4Taco.Models
{
    public class UserStep: StoryMapItem
    {
        public virtual ICollection<UserStory> UserStories { get; set; }
    }
}