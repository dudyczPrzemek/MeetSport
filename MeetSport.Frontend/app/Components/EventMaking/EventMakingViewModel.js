function EventMakingViewModel(sportsList) {
    var self = this;

    self.EventMakingViewModel = ko.observable();

    self.sports = ko.observableArray(sportsList);

    self.EventDescription = ko.observable();
    self.Date = ko.observable();
    self.PlayersNeeded = ko.observable();

    self.Address = ko.observable({
        City: ko.observable(),
        Street: ko.observable()
    });
    //self.Sport = ko.observable({
    //    Id: ko.observable(),
    //    Name: ko.observable()
    //});

    self.Sport = ko.observable();

    self.Cost = ko.observable();
    self.StartTime = ko.observable();
    self.EndTime = ko.observable();

    self.Sport = ko.observable({
        Id: ko.observable(),
        Name: ko.observable()
    });

    self.addEvent = function () {
        eventService.addEvent(self, function () {
            window.location = "#Greetings";
        });
    }

    self.init = function () {
        sportsService.loadAllSports(self.sports);
    }
}