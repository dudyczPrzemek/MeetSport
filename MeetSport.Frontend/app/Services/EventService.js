function EventService() {
    var self = this;

    self.addEvent = function (model, callback) {

        $.ajax("/api/Event", {
            dataType: "json",
            type: "PUT",
            data: ko.toJSON(model),
            contentType: "application/json; charset=utf-8",
            headers: {
                'Authorization': "Bearer " + authManager.getToken()
            },
            success: function (data) {
                callback(model);
            }
        });
    }

    self.getNewEvents = function (cityName, list)
    {
        $.ajax("/api/Event", {
            dataType: "json",
            type: "GET",
            data: {cityName: cityName},
            contentType: "application/json; charset=utf-8",
            headers: {
                'Authorization': "Bearer " + authManager.getToken()
            },
            success: function (data) {
                var news = ko.mapping.fromJS(data);

                for (var i = 0; i < news().length; ++i)
                {
                    news()[i].Date(news()[i].Date().slice(0, 10));
                    news()[i].StartTime(news()[i].StartTime().slice(11, 16));
                    news()[i].EndTime(news()[i].EndTime().slice(11, 16));
                    var time = news()[i].StartTime().slice(11, 16).toString() + "-" + news()[i].EndTime().slice(11, 16).toString();

                    news()[i].Time = ko.observable(time);
                }

                list(news());
            }
        });
    }

    self.search = function(sport, city, date)
    {
        debugger;
        $.ajax("/api/Event", {
            dataType: "json",
            type: "GET",
            data: {sportName: sport().Name(), cityName: city, date: date},
            contentType: "application/json; charset=utf-8",
            headers: {
                'Authorization': "Bearer " + authManager.getToken()
            },
            success: function (data) {
                callback(data);
            }
        });
    }
}

var eventService = new EventService();
