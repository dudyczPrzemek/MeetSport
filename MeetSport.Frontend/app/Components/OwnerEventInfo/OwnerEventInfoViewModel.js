function OwnerEventInfoViewModel() {
    var self = this;

    self.Event = ko.observableArray();

    self.init = function (id) {
        eventService.getEvent(self.Event, id);
    }
}