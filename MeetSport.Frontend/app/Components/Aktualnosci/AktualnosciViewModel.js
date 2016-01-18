function AktualnosciViewModel() {
    var self = this;

    self.cities = ko.observableArray(['Wroclaw', 'Legnica']);

    self.NewEvents = ko.observableArray();

    self.selectedCity = ko.observable('Legnica');

    self.isData = ko.computed(function () {
        return self.NewEvents().length > 0;
    });

    self.init = function ()
    {
        self.cityChange();
    }

    self.cityChange = function()
    {
        eventService.getNewEvents(self.selectedCity(), self.NewEvents);
    }
}