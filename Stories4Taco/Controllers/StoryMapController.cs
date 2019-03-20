using Stories4Taco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Stories4Taco.Controllers
{
    public class StoryMapController : ApiController
    {
        // GET api/storyMap
        public object Get()
        {
            using (var db = new Context())
            {

                List<Goal> goals = db.Goals.Include(x => x.UserSteps.Select(step => step.UserStories.Select(story => story.Release))).ToList();
                List<Release> releases = db.Releases.ToList();

                return new { goals = goals, releases = releases };
            }
        }
    }
}
