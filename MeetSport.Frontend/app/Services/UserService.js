function UserService() {
    var self = this;

    var api = new API("User", {
        Id: Number,
        UserName: String,
        FirstName: String,
        LastName: String,
        Email: String,
    });

    self.getUser = function (username, callback) {
        api.query(function(user) { return user.UserName === this.username; }, { username: username }, function(items) {
            callback(items[0]);
        });
    }
};

var userService = new UserService();