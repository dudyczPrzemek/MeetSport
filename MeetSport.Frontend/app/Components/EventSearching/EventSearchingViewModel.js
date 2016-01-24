function EventSearchingViewModel() {
    var self = this;

    self.sports = ko.observableArray();
    self.cities = ko.observableArray(['Wroclaw', 'Legnica']);
    self.date = ko.observable();
    self.selectedSport = ko.observable();
    self.selectedCity = ko.observable();

    self.searchedEvents = ko.observableArray();

    self.init = function ()
    {
        sportsService.loadAllSports(self.sports);
    }

    self.search = function () {
        eventService.search(self.searchedEvents, self.selectedSport, self.selectedCity, self.date);
    }

    self.goToEventInfo = function (model) {
        window.location = "#EventInfo/" + model.Id();
    }
}