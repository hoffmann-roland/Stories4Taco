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

                List<Goal> goals = db.Goals.Include(x => x.UserSteps).ToList();
                List<Release> releases = db.Releases.Include(x => x.UserStories).ToList();

                return new { goals = goals, releases = releases };
            }
        }
    }
}
