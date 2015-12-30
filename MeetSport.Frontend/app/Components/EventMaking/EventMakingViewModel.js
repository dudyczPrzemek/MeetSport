function EventMakingViewModel(sportsList) {
    var self = this;

    self.EventMakingViewModel = ko.observable();

    self.sports = ko.observableArray(sportsList);

    self.init = function () {
        sportsService.loadAllSports(self.sports);
    }
}