function YourEventsViewModel() {
    var self = this;

    self.Events = ko.observableArray();

    self.init = function ()
    {
        var user = userData.Get();

        eventService.getEventsForUser(self.Events, user.Email);
    }

    self.goToEventInfo = function (model) {
        window.location = "#EventInfo/" + model.Id();
    }

}