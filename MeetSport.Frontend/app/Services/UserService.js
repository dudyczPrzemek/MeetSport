function UserService() {

    var self = this;

    function handleLogOut() {
        toastr.error("Zostałeś wylogowany!", "Błąd");
        cache.ClearAll();
        routing.refresh();
    }

    function handleStandardError(jqXHR, exception) {
        if (jqXHR.status === 401) {
            handleLogOut();
            return true;
        }
        return false;
    }

    var UserAPI = $data.define("User", {
        Id: Number,
        UserName: String,
        FirstName: String,
        LastName: String,
        Email: String,
    });

    UserAPI.setStore('default', {
        provider: 'webApi',
        dataSource: '/api/user'
    });

    $data.EntityContext.prototype.prepareRequest = function (r) {
        r.headers['Authorization'] = "Bearer " + authManager.getToken();
    };
    
    self.getUser = function (username, callback) {
        UserAPI.query(function (user) { return user.UserName === this.username; }, {username: username})
            .then(function (items) {
                callback(items[0]);
            })
            .fail(function (err) {
                console.log("item not found");
            });
    }
};

var userService = new UserService();