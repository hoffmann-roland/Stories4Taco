using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stories4Taco.Models
{
    public class UserStory: StoryMapItem
    {
        public virtual Release Release { get; set; }
    }
}