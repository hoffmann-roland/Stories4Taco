using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stories4Taco.Models
{
    public abstract class StoryMapItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}