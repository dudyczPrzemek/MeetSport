function EventSearchingViewModel() {
    var self = this;

    self.sports = ko.observableArray();
    self.cities = ko.observableArray(['Wroclaw', 'Legnica']);
    self.date = ko.observable();
    self.selectedSport = ko.observable();
    self.selectedCity = ko.observable();


    self.init = function ()
    {
        sportsService.loadAllSports(self.sports);
    }

    self.search = function () {
        eventService.search(self.selectedSport, self.selectedCity, self.date);
    }
}