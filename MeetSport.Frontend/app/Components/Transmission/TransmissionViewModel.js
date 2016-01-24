function TransmissionViewModel() {
    var self = this;

    self.Transmission = ko.observable();

    self.userDesc = ko.computed(function () {
        var result = "";
        if (self.Transmission())
            result = "Nagranie użytownika: " + self.Transmission().OwnerName;
        return result;
    });

    self.isTransmissionOfLoggedUser = ko.computed(function () {
        var user = userData.Get();
        var result = true;
        if (self.Transmission())
            result = user.Email === self.Transmission().OwnerName

        return result;
    });

    self.init = function (Id) {
        transmissionService.getTransmission(self.Transmission, Id);

        setTimeout(function () { }, 10000);
    }
}