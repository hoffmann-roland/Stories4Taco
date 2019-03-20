var vm = {
    goals: ko.observableArray(),
    releases: ko.observableArray(),
};

ko.applyBindings(vm);

$.get("../api/storyMap", function (data) {
    vm.goals(data.goals);

    var releases = [];
    data.releases.forEach(function (release) {
        var newRelease = { Name: release.Name, Goals: [] };
        var isReleaseEmpty = true;
        newRelease.Goals = data.goals.map(function (goal) {
            var newGoal = { Name: goal.Name, UserSteps: [] };
            newGoal.UserSteps = goal.UserSteps.map(function (userStep) {
                var newUserStep = { Name: userStep.Name, UserStories: [] };
                userStep.UserStories.forEach(function (userStory) {
                    if (userStory.Release.Id === release.Id) {
                        newUserStep.UserStories.push(userStory);
                        isReleaseEmpty = false;
                    }
                });
                return newUserStep;
            });
            return newGoal;
        });
        if (!isReleaseEmpty) {
            releases.push(newRelease);
        }
    });

    vm.releases(releases);
});