function SportsService() {
    var self = this;

    self.loadAllSports = function (list) {
        $.ajax("/api/Sports",{
            dataType: "json",
            type: "GET",
            headers: {
                'Authorization': "Bearer " + authManager.getToken()
            },
            success: function (data) {
                var sports = ko.mapping.fromJS(data);
                list(sports());
            }
        });
    }
}

var sportsService = new SportsService();