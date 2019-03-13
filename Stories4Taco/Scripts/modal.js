var vm = {
    goals: ko.observableArray(),
    releases: ko.observableArray(),
};

ko.applyBindings(vm);

$.get("../api/storyMap", function (data) {
    vm.goals(data.goals);
    //vm.releases(data.releases);

    data.releases.forEach(function (release) {
        release.Goals = data.goals.map(function (goal) {
            var newGoal = { Name: goal.Name, UserSteps: [] };
            newGoal.UserSteps = goal.UserSteps.map(function (userStep) {
                var newUserStep = { Name: userStep.Name, UserStories: [] };
                release.UserStories.forEach(function (userStory) {
                    if (userStory.UserStepId === userStep.Id)
                        newUserStep.UserStories.push(userStory);
                });
                return newUserStep;
            });
            return newGoal;
        });
    });

    vm.releases(data.releases);
});