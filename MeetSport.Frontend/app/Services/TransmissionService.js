function TransmissionService() {
    var self = this;

    self.addTransmission = function(model, callback)
    {
        $.ajax("/api/Transmission", {
            dataType: "json",
            type: "PUT",
            data: ko.toJSON(model),
            contentType: "application/json; charset=utf-8",
            headers: {
                'Authorization': "Bearer " + authManager.getToken()
            },
            success: function (data) {
                callback(model);
            },
            error: function () {
                callback();
            }
        });
    }

    self.getTransmissions = function (list) {
        $.ajax("/api/Transmission", {
            dataType: "json",
            type: "GET",
            contentType: "application/json; charset=utf-8",
            headers: {
                'Authorization': "Bearer " + authManager.getToken()
            },
            success: function (data) {
                var transmissions = ko.mapping.fromJS(data);

                list(transmissions());
            }
        });
    }

    self.getTransmission = function (model, id) {
        $.ajax("/api/Transmission", {
            dataType: "json",
            type: "GET",
            contentType: "application/json; charset=utf-8",
            data: {Id: id},
            headers: {
                'Authorization': "Bearer " + authManager.getToken()
            },
            success: function (data) {

                model(data);
            }
        });
    }
}

var transmissionService = new TransmissionService();