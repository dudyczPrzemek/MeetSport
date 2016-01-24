function LiveEventsViewModel() {
    var self = this;

    self.Url = ko.observable();

    self.Title = ko.observable();

    self.addTransmission = function ()
    {
        transmissionService.addTransmission(self, function () {
            window.location = '#Greetings';
        });
    }

    self.Transmissions = ko.observableArray();

    self.init = function () {
        transmissionService.getTransmissions(self.Transmissions);
    }

    self.goToTransDetails = function (model) {
        window.location = "#Transmission/" + model.Id();
    }
}