﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stories4Taco.Models
{
    public class Release
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("ReleaseId")]
        public virtual ICollection<UserStory> UserStories { get; set; }
    }
}