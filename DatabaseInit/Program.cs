using Stories4Taco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseInit
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                var releases = new List<Release> {
                    new Release { Name = "Release 1" },
                    new Release { Name = "Release 2" },
                    new Release { Name = "Release 3" },
                    new Release { Name = "Release 4" },
                    new Release { Name = "Release 5" }
                };

                var userStoriesForUserStep2 = new List<UserStory> {
                    new UserStory { Name = "UserStory 1 2 1 - Release:1", Release = releases[0] },
                    new UserStory { Name = "UserStory 1 2 2 - Release:1", Release = releases[0] },
                    new UserStory { Name = "UserStory 1 2 3 - Release:2", Release = releases[1] }
                };

                var userStoriesForUserStep4 = new List<UserStory> {
                    new UserStory { Name = "UserStory 4 1 1 - Release:1", Release = releases[0] },
                    new UserStory { Name = "UserStory 4 1 2 - Release:2", Release = releases[1] }
                };

                var userStepsForGoal1 = new List<UserStep> {
                    new UserStep { Name = "UserStep 1 1" },
                    new UserStep { Name = "UserStep 1 2", UserStories = userStoriesForUserStep2 },
                    new UserStep { Name = "UserStep 1 3" }
                };

                var userStepsForGoal4 = new List<UserStep> {
                    new UserStep { Name = "UserStep 4 1", UserStories =  userStoriesForUserStep4 },
                    new UserStep { Name = "UserStep 4 2" }
                };

                var goals = new List<Goal> {
                    new Goal { Name = "Goal 1", UserSteps = userStepsForGoal1 },
                    new Goal { Name = "Goal 2" },
                    new Goal { Name = "Goal 3" },
                    new Goal { Name = "Goal 4", UserSteps = userStepsForGoal4 },
                    new Goal { Name = "Goal 5" }
                };

                db.Goals.AddRange(goals);
                db.Releases.AddRange(releases);

                db.SaveChanges();

                var goalsFromDb = db.Goals.ToList();
            }
        }
    }
}
